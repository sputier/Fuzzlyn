// Generated by Fuzzlyn on 2018-06-03 23:00:51
// Seed: 15652638411539516545
class C0
{
    public ushort F0;
    public short F1;
    public sbyte F2;
    public short F3;
    public uint F4;
    public C0(ushort f0, short f1, sbyte f2, short f3, uint f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

struct S0
{
    public uint F0;
    public uint F1;
    public sbyte F2;
    public char F3;
    public uint F4;
    public S0(uint f0, uint f1, sbyte f2, char f3, uint f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

struct S1
{
    public S0 F0;
    public S0 F1;
    public sbyte F2;
    public S1(S0 f0, S0 f1, sbyte f2)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }
}

struct S2
{
    public S0 F0;
    public int F1;
    public uint F2;
    public S2(S0 f0, int f1, uint f2)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        S0 var0 = new S0(855172573U, 0U, 2, 'L', 1367152188U);
        var0.F1 = var0.F4;
        var0.F3 = (char)(var0.F2 + (byte)(var0.F3 | var0.F0));
    }
}