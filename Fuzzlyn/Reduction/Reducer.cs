﻿using Fuzzlyn.Execution;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Fuzzlyn.Reduction
{
    internal class Reducer
    {
        private readonly Rng _rng;
        private int _varCounter;

        public Reducer(CompilationUnitSyntax original, ulong reducerSeed)
        {
            Original = original;
            _rng = Rng.FromSplitMix64Seed(reducerSeed);
        }

        public FuzzlynOptions Options { get; }
        public CompilationUnitSyntax Original { get; }
        public CompilationUnitSyntax Reduced { get; private set; }

        public CompilationUnitSyntax Reduce()
        {
            CompileResult debug = Compiler.Compile(Original, Compiler.DebugOptions);
            CompileResult release = Compiler.Compile(Original, Compiler.ReleaseOptions);

            if (debug.CompileDiagnostics.Length > 0 || release.CompileDiagnostics.Length > 0)
            {
                ImmutableArray<Diagnostic> diags =
                    debug.CompileDiagnostics.Length > 0 ? debug.CompileDiagnostics : release.CompileDiagnostics;

                IEnumerable<Diagnostic> errs = diags.Where(d => d.Severity == DiagnosticSeverity.Error);
                string errorString = string.Join(Environment.NewLine, errs.Select(e => "  " + e));
                throw new InvalidOperationException("Program has compile errors: " + Environment.NewLine + errorString);
            }

            Func<CompilationUnitSyntax, bool> isBad;
            if (debug.RoslynException != null || release.RoslynException != null)
            {
                CSharpCompilationOptions opts = debug.RoslynException != null ? Compiler.DebugOptions : Compiler.ReleaseOptions;
                isBad = program => Compiler.Compile(program, opts).RoslynException != null;
            }
            else
            {
                var origPair = new ProgramPair(debug.Assembly, release.Assembly);
                ProgramPairResults origResults = ProgramExecutor.RunPair(origPair);
                if (origResults.DebugResult.Checksum == origResults.ReleaseResult.Checksum &&
                    origResults.DebugResult.ExceptionType == origResults.ReleaseResult.ExceptionType)
                {
                    throw new InvalidOperationException("Program has no errors");
                }

                isBad = prog =>
                {
                    CompileResult progDebug = Compiler.Compile(prog, Compiler.DebugOptions);
                    CompileResult progRelease = Compiler.Compile(prog, Compiler.ReleaseOptions);

                    //Debug.Assert(progDebug.Assembly != null && progRelease.Assembly != null);
                    if (progDebug.Assembly == null || progRelease.Assembly == null)
                        return false;

                    ProgramPair pair = new ProgramPair(progDebug.Assembly, progRelease.Assembly);
                    if (pair == null)
                        return false;

                    ProgramPairResults results = ProgramExecutor.RunPair(pair);
                    // Do exceptions first because they will almost always change checksum
                    if (origResults.DebugResult.ExceptionType != origResults.ReleaseResult.ExceptionType)
                    {
                        // Must throw same exceptions in debug and release to be bad.
                        return results.DebugResult.ExceptionType == origResults.DebugResult.ExceptionType &&
                               results.ReleaseResult.ExceptionType == origResults.ReleaseResult.ExceptionType;
                    }

                    return results.DebugResult.Checksum != results.ReleaseResult.Checksum;
                };
            }

            // Save original comments as simplification may remove it by removing an unnecessary type.
            SyntaxTriviaList originalTrivia = Original.GetLeadingTrivia();
            Reduced = Original.WithLeadingTrivia();
            List<SyntaxNode> simplifiedNodes = new List<SyntaxNode>();
            bool first = true;
            bool any = true;
            while (any)
            {
                any = false;
                while (true)
                {
                    if (!SimplifyOne("Statements", Reduced.DescendantNodes().Where(n => n is StatementSyntax).ToList()))
                        break;
                    any = true;
                }

                while (true)
                {
                    if (!SimplifyOne("Expressions", Reduced.DescendantNodes().Where(n => n is ExpressionSyntax).ToList()))
                        break;
                    any = true;
                }

                while (true)
                {
                    List<SyntaxNode> members =
                        Reduced.DescendantNodesAndSelf().Where(n => n is MemberDeclarationSyntax || n is CompilationUnitSyntax).ToList();

                    if (!SimplifyOne("Members", members))
                        break;
                    any = true;
                }

                first = false;

                bool SimplifyOne(string name, List<SyntaxNode> list)
                {
                    for (int i = 0; i < 2000; i++)
                    {
                        Console.Title = $"Simplifying {name}. Iter: {i}";

                        SyntaxNode node = list[_rng.Next(list.Count)];

                        // If we fail at creating a new bad example, then we want to be able to restore the state
                        // so the reducer will not blow these up unnecessarily.
                        int origVarCounter = _varCounter;

                        simplifiedNodes.Clear();
                        SimplifyNode(node, !first, simplifiedNodes);

                        foreach (SyntaxNode candidateNode in simplifiedNodes)
                        {
                            CompilationUnitSyntax candidate = Reduced.ReplaceNode(node, candidateNode);
                            if (isBad(candidate))
                            {
                                Reduced = candidate;
                                return true;
                            }
                        }

                        _varCounter = origVarCounter;
                    }

                    return false;
                }
            }

            SimplifyRuntime();
            double oldSizeKB = Original.NormalizeWhitespace().ToString().Length / 1024.0;
            double newSizeKB = Reduced.NormalizeWhitespace().ToString().Length / 1024.0;
            SyntaxTriviaList newTrivia =
                originalTrivia.Add(Comment(FormattableString.Invariant($"// Reduced from {oldSizeKB:F1} KB to {newSizeKB:F1} KB")));
            Reduced = Reduced.WithLeadingTrivia(newTrivia);

            return Reduced;
        }

        /// <summary>
        /// Simplifies everything related to the runtime; removes the s_rt field,
        /// and associated assignments, and converts checksum calls into Console.WriteLine.
        /// </summary>
        private void SimplifyRuntime()
        {
            // First remove argument to Main
            MethodDeclarationSyntax mainMethod =
                Reduced.DescendantNodes().OfType<MethodDeclarationSyntax>().Single(m => m.Identifier.Text == "Main");

            Reduced = Reduced.ReplaceNode(mainMethod, mainMethod.WithParameterList(ParameterList()));

            Dictionary<SyntaxNode, SyntaxNode> replacements = new Dictionary<SyntaxNode, SyntaxNode>();
            foreach (SyntaxNode node in Reduced.DescendantNodes())
            {
                // Remove s_rt field
                if (node is FieldDeclarationSyntax field && field.Declaration.Variables.Count == 1 &&
                    field.Declaration.Variables[0].Identifier.Text == "s_rt")
                {
                    replacements.Add(node, null);
                    continue;
                }

                if (!(node is ExpressionStatementSyntax expStmt))
                    continue;

                // Remove s_rt = rt
                if (expStmt.Expression is AssignmentExpressionSyntax asgn && asgn.Left is IdentifierNameSyntax id &&
                    id.Identifier.Text == "s_rt")
                {
                    replacements.Add(node, null);
                    continue;
                }

                // Convert s_rt.Checksum() calls to System.Console.WriteLine
                if (expStmt.Expression is InvocationExpressionSyntax invoc && invoc.Expression is MemberAccessExpressionSyntax mem &&
                    mem.Name.Identifier.Text == "Checksum")
                {
                    ArgumentSyntax arg = invoc.ArgumentList.Arguments[1];
                    ExpressionStatementSyntax newCall =
                        ExpressionStatement(
                            InvocationExpression(
                                ParseExpression("System.Console.WriteLine"),
                                ArgumentList(
                                    SingletonSeparatedList(arg))));

                    replacements.Add(node, newCall);
                }
            }

            Reduced = Reduced.ReplaceNodes(replacements.Keys, (orig, _) => replacements[orig]);
        }

        private readonly List<(bool late, Func<SyntaxNode, SyntaxNode> simp)> _simplifiers =
            new List<(bool late, Func<SyntaxNode, SyntaxNode> simp)>();

        private void SimplifyNode(SyntaxNode node, bool late, List<SyntaxNode> simplifiedNodes)
        {
            if (_simplifiers.Count == 0)
            {
                MethodInfo[] methods = typeof(Reducer).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
                IEnumerable<MethodInfo> prioritized =
                    methods
                    .Select(m => (method: m, attrib: m.GetCustomAttribute<SimplifierAttribute>()))
                    .Where(t => t.attrib != null)
                    .OrderByDescending(t => t.attrib.Priority)
                    .Select(t => t.method);

                foreach (MethodInfo method in prioritized)
                {
                    SimplifierAttribute attrib = method.GetCustomAttribute<SimplifierAttribute>();
                    if (attrib == null)
                        continue;

                    Delegate dlg = Delegate.CreateDelegate(typeof(Func<SyntaxNode, SyntaxNode>), this, method);
                    _simplifiers.Add((attrib.Late, (Func<SyntaxNode, SyntaxNode>)dlg));
                }
            }

            foreach (var (simpLate, simplifier) in _simplifiers)
            {
                if (simpLate && !late)
                    continue;

                SyntaxNode simplified = simplifier(node);
                if (simplified != node)
                    simplifiedNodes.Add(simplified);
            }
        }

        // Simplify "bool b = s_2 == M();" to "M();"
        [Simplifier]
        private SyntaxNode SimplifyLocalWithCall(SyntaxNode node)
        {
            if (!(node is LocalDeclarationStatementSyntax local) || local.Declaration.Variables.Count != 1)
                return node;

            List<InvocationExpressionSyntax> calls = local.DescendantNodes().OfType<InvocationExpressionSyntax>().ToList();
            if (calls.Count <= 0)
                return node;

            return ExpressionStatement(calls[_rng.Next(calls.Count)]);
        }

        // Simplify "int a = expr;" to "int a;"
        [Simplifier]
        private SyntaxNode SimplifyLocalRemoveInitializer(SyntaxNode node)
        {
            if (!(node is LocalDeclarationStatementSyntax local) || local.Declaration.Variables.Count != 1)
                return node;

            return
                local.WithDeclaration(
                    local.Declaration
                    .WithVariables(
                        SingletonSeparatedList(
                            local.Declaration.Variables[0].WithInitializer(null))));
        }

        // Inline calls. We only do this late since it is better to reduce each call before inlining.
        [Simplifier(Late = true)]
        private SyntaxNode InlineCall(SyntaxNode node)
        {
            if (!(node is ClassDeclarationSyntax cls))
                return node;

            // We require invocations to be on the form
            // M(var1, var2, ...)
            // so we can simply replace parameters with those variables. We have other simplifications that rewrite
            // invocations to that form.
            List<InvocationExpressionSyntax> invocs =
                cls.DescendantNodes()
                .OfType<InvocationExpressionSyntax>()
                .Where(i => i.Expression is IdentifierNameSyntax && i.ArgumentList.Arguments.All(a => a.Expression is IdentifierNameSyntax))
                .ToList();

            if (invocs.Count <= 0)
                return node;

            InvocationExpressionSyntax invoc = invocs[_rng.Next(invocs.Count)];

            MethodDeclarationSyntax target =
                cls.DescendantNodes()
                .OfType<MethodDeclarationSyntax>()
                .FirstOrDefault(m => m.Identifier.Text == ((IdentifierNameSyntax)invoc.Expression).Identifier.Text);

            // Cannot yet inline functions that have multiple returns, or returns in different position than last...
            int numReturns = target.Body.Statements.Count(s => s is ReturnStatementSyntax);
            if (numReturns > 1 || (numReturns == 1 && !(target.Body.Statements.Last() is ReturnStatementSyntax)))
                return node;

            Debug.Assert(target != null);

            List<StatementSyntax> finalStatements = new List<StatementSyntax>();
            // For cases like
            // char a = '0';
            // M(a);
            // where M is void M(uint b) { }
            // we need to replace usages of b with (uint)a, not just a.
            Dictionary<string, SyntaxNode> argReplacements =
                target.ParameterList.Parameters
                .Zip(invoc.ArgumentList.Arguments, (param, arg) => (param, arg))
                .ToDictionary(
                    t => t.param.Identifier.Text,
                    t => (SyntaxNode)CastExpression(t.param.Type, IdentifierName(((IdentifierNameSyntax)t.arg.Expression).Identifier.Text)));

            // Give locals new names
            Dictionary<string, string> localReplacements = new Dictionary<string, string>();
            foreach (VariableDeclaratorSyntax varDecl in
                target.Body.DescendantNodes().OfType<VariableDeclaratorSyntax>())
            {
                localReplacements.Add(varDecl.Identifier.Text, MakeLocalName());
            }

            string valueName = null;
            foreach (StatementSyntax stmt in target.Body.Statements)
            {
                IEnumerable<SyntaxToken> tokens =
                    stmt.DescendantTokens()
                        .Where(t => t.IsKind(SyntaxKind.IdentifierToken) && localReplacements.ContainsKey(t.Text));

                StatementSyntax newStmt =
                    stmt.ReplaceTokens(tokens, (orig, _) => Identifier(localReplacements[orig.Text]));

                newStmt =
                    newStmt.ReplaceNodes(
                        newStmt.DescendantNodes()
                        .OfType<IdentifierNameSyntax>()
                        .Where(id => argReplacements.ContainsKey(id.Identifier.Text)),
                        (orig, _) => argReplacements[orig.Identifier.Text]);

                if (newStmt is ReturnStatementSyntax ret)
                {
                    if (ret.Expression == null)
                        continue;

                    (newStmt, valueName) = MakeLocalDecl(ret.Expression, target.ReturnType);
                }

                finalStatements.Add(newStmt);
            }

            bool replaceUsage = !(invoc.Parent is ExpressionStatementSyntax);
            Debug.Assert(!replaceUsage || valueName != null, "We need to replace usage but no return statement was found");

            StatementSyntax containingInvoc = invoc.FirstAncestorOrSelf<StatementSyntax>();
            if (replaceUsage)
            {
                finalStatements.Add(containingInvoc.ReplaceNode(invoc, IdentifierName(valueName)));
            }

            BlockSyntax containingBlock = invoc.FirstAncestorOrSelf<BlockSyntax>();
            SyntaxNode newNode =
                node.ReplaceNode(
                    containingBlock,
                    containingBlock.WithStatements(
                        containingBlock.Statements.ReplaceRange(containingInvoc, finalStatements)));

            return newNode;
        }

        // Remove statements
        [Simplifier(Priority = 1)]
        private SyntaxNode SimplifyStatementRemove(SyntaxNode node)
        {
            if (!(node is StatementSyntax) || !(node.Parent is BlockSyntax))
                return node;

            return null;
        }

        [Simplifier]
        private SyntaxNode SimplifyIfToThen(SyntaxNode node)
        {
            if (!(node is IfStatementSyntax @if))
                return node;

            return @if.Statement;
        }

        [Simplifier]
        private SyntaxNode SimplifyIfToElse(SyntaxNode node)
        {
            if (!(node is IfStatementSyntax @if) || @if.Else == null)
                return node;

            return @if.Else.Statement;
        }

        [Simplifier]
        private SyntaxNode SimplifyBinaryExpressionToLeft(SyntaxNode node)
        {
            if (!(node is BinaryExpressionSyntax bin))
                return node;

            return bin.Left;
        }

        [Simplifier]
        private SyntaxNode SimplifyBinaryExpressionToRight(SyntaxNode node)
        {
            if (!(node is BinaryExpressionSyntax bin))
                return node;

            return bin.Right;
        }

        [Simplifier]
        private SyntaxNode SimplifyCast(SyntaxNode node)
        {
            if (!(node is CastExpressionSyntax cast))
                return node;

            return cast.Expression;
        }

        [Simplifier]
        private SyntaxNode SimplifyParenthesized(SyntaxNode node)
        {
            if (!(node is ParenthesizedExpressionSyntax p))
                return node;

            if (Helpers.RequiresParentheses(p.Expression))
                return node;

            return p.Expression;
        }

        [Simplifier]
        private SyntaxNode SimplifyPrefixUnaryExpression(SyntaxNode node)
        {
            if (!(node is PrefixUnaryExpressionSyntax p))
                return node;

            return p.Operand;
        }

        [Simplifier]
        private SyntaxNode SimplifyPostfixUnaryExpression(SyntaxNode node)
        {
            if (!(node is PostfixUnaryExpressionSyntax p))
                return node;

            return p.Operand;
        }

        [Simplifier]
        private SyntaxNode SimplifyInitializer(SyntaxNode node)
        {
            if (!(node is InitializerExpressionSyntax init))
                return node;

            if (init.Kind() != SyntaxKind.ArrayInitializerExpression || init.Expressions.Count < 1)
                return node;

            return init.WithExpressions(SingletonSeparatedList(init.Expressions[0]));
        }

        [Simplifier]
        private SyntaxNode SimplifyBlockFlatten(SyntaxNode node)
        {
            if (!(node is BlockSyntax block) || !block.Statements.Any(s => s is BlockSyntax))
                return node;

            return block.WithStatements(
                block.Statements.SelectMany(s => s is BlockSyntax bs ? bs.Statements : Enumerable.Repeat(s, 1)).ToSyntaxList());
        }

        [Simplifier]
        private SyntaxNode RemoveMethodDeclaration(SyntaxNode node)
        {
            if (!(node is MethodDeclarationSyntax method) || method.Identifier.Text == "Main")
                return node;

            return null;
        }

        [Simplifier]
        private SyntaxNode RemoveTypeDeclaration(SyntaxNode node)
        {
            if (!(node is TypeDeclarationSyntax type) || type.Identifier.Text == "Program")
                return node;

            return null;
        }

        [Simplifier]
        private SyntaxNode RemoveFieldDeclaration(SyntaxNode node)
        {
            if (!(node is FieldDeclarationSyntax field))
                return node;

            return null;
        }

        [Simplifier]
        private SyntaxNode RemoveMethodArgument(SyntaxNode node)
        {
            if (!(node is CompilationUnitSyntax unit))
                return node;

            List<(ParameterSyntax pm, int index)> methodParams =
                unit.DescendantNodes().OfType<BaseMethodDeclarationSyntax>()
                .Where(m => !(m is MethodDeclarationSyntax normalMethod) || normalMethod.Identifier.Text != "Main")
                .SelectMany(m => m.ParameterList.Parameters.Select((p, i) => (p, i))).ToList();

            if (methodParams.Count == 0)
                return node;

            var (parameter, index) = methodParams[_rng.Next(methodParams.Count)];
            BaseMethodDeclarationSyntax method = (BaseMethodDeclarationSyntax)parameter.Parent.Parent;
            Func<SyntaxNode, bool> isInvoc;
            Func<SyntaxNode, ArgumentListSyntax> getInvocArgs;
            if (method is MethodDeclarationSyntax)
            {
                isInvoc = n => n is InvocationExpressionSyntax invoc &&
                          invoc.Expression is IdentifierNameSyntax id &&
                          id.Identifier.Text == ((MethodDeclarationSyntax)method).Identifier.Text;
                getInvocArgs = n => ((InvocationExpressionSyntax)n).ArgumentList;
            }
            else if (method is ConstructorDeclarationSyntax)
            {
                isInvoc = n => n is ObjectCreationExpressionSyntax creation &&
                               creation.Type is IdentifierNameSyntax id &&
                               id.Identifier.Text == ((ConstructorDeclarationSyntax)method).Identifier.Text;
                getInvocArgs = n => ((ObjectCreationExpressionSyntax)n).ArgumentList;
            }
            else
                return node;

            SyntaxNode methodWithoutParam =
                method.ReplaceNode(
                    method.ParameterList,
                    method.ParameterList.WithParameters(method.ParameterList.Parameters.RemoveAt(index)));

            SyntaxNode newNode = unit.ReplaceNode(method, methodWithoutParam);
            while (true)
            {
                SyntaxNode invoc =
                    newNode.DescendantNodes().FirstOrDefault(
                        i => isInvoc(i) && getInvocArgs(i).Arguments.Count == method.ParameterList.Parameters.Count);

                if (invoc == null)
                    break;

                ArgumentListSyntax args = getInvocArgs(invoc);
                ArgumentListSyntax newArgs = args.WithArguments(args.Arguments.RemoveAt(index));
                newNode = newNode.ReplaceNode(args, newArgs);
            }

            return newNode;
        }

        [Simplifier]
        private SyntaxNode SimplifyInvocationExtractArgs(SyntaxNode node)
        {
            // Simplify a random invocation in a block from
            // M(expr1, expr2)
            // or
            // a = M(expr1, expr2)
            // or
            // var a = M(expr1, expr2)
            // to
            // var arg1 = expr1;
            // var arg2 = expr2;
            // [var a = ] M(arg1, arg2)

            if (!(node is BlockSyntax block))
                return node;

            List<InvocationExpressionSyntax> invocs = new List<InvocationExpressionSyntax>();
            foreach (StatementSyntax stmt in block.Statements)
            {
                if (stmt is ExpressionStatementSyntax expStmt)
                {
                    if (expStmt.Expression is InvocationExpressionSyntax inv1)
                        invocs.Add(inv1);
                    else if (expStmt.Expression is AssignmentExpressionSyntax asgn &&
                             asgn.Right is InvocationExpressionSyntax inv2)
                    {
                        invocs.Add(inv2);
                    }
                }
                else if (stmt is LocalDeclarationStatementSyntax local &&
                         local.Declaration.Variables.Count == 1 &&
                         local.Declaration.Variables[0].Initializer?.Value is InvocationExpressionSyntax inv3)
                {
                    invocs.Add(inv3);
                }
            }

            // Remove ones that already have only variables as arguments, including ones with 0 arguments.
            invocs.RemoveAll(inv => inv.ArgumentList.Arguments.All(a => a.Expression is IdentifierNameSyntax));
            // Remove checksums
            invocs.RemoveAll(inv => inv.Expression is MemberAccessExpressionSyntax mem && mem.Name.Identifier.Text == "Checksum");

            if (invocs.Count <= 0)
                return node;

            InvocationExpressionSyntax invoc = invocs[_rng.Next(invocs.Count)];
            int statementIndex =
                block.Statements.Select((s, i) => (s, i)).Single(t => t.s.Contains(invoc)).i;

            List<StatementSyntax> newVars = new List<StatementSyntax>();
            List<ArgumentSyntax> newArgs = new List<ArgumentSyntax>();

            foreach (ArgumentSyntax arg in invoc.ArgumentList.Arguments)
            {
                if (arg.Expression is IdentifierNameSyntax id)
                {
                    newArgs.Add(arg);
                    continue;
                }

                var (local, name) = MakeLocalDecl(arg.Expression);
                newVars.Add(local);
                newArgs.Add(Argument(IdentifierName(name)));
            }

            BlockSyntax newBlock = block.ReplaceNode(invoc, invoc.WithArgumentList(ArgumentList(SeparatedList(newArgs))));
            newBlock = newBlock.WithStatements(newBlock.Statements.InsertRange(statementIndex, newVars));
            return newBlock;
        }

        private (LocalDeclarationStatementSyntax local, string name) MakeLocalDecl(ExpressionSyntax expr, TypeSyntax type = null)
        {
            string name = MakeLocalName();

            LocalDeclarationStatementSyntax local =
                LocalDeclarationStatement(
                    VariableDeclaration(
                        type ?? IdentifierName("var"),
                        SingletonSeparatedList(
                            VariableDeclarator(name)
                            .WithInitializer(
                                EqualsValueClause(
                                    expr)))));

            return (local, name);
        }

        private string MakeLocalName() => $"vr{_varCounter++}";

        [AttributeUsage(AttributeTargets.Method)]
        private class SimplifierAttribute : Attribute
        {
            public int Priority { get; set; }
            public bool Late { get; set; }
        }
    }
}