// Generated by Fuzzlyn on 2018-06-03 22:05:15
// Seed: 10744458083861091494
// Reduced from 21.4 KB to 0.2 KB
// Debug: Outputs 246
// Release: Outputs 4294967286
public class Program
{
    static sbyte s_1 = -10;
    public static void Main()
    {
        var vr42 = 11331382023890235109UL;
        vr42 = (byte)(0U ^ s_1);
        System.Console.WriteLine(vr42);
    }
}