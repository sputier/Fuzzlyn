// Generated by Fuzzlyn on 2018-06-03 22:21:20
// Seed: 11855651672803758179
// Reduced from 197.7 KB to 0.3 KB
// Debug: Outputs 165
// Release: Outputs -91
public class Program
{
    static sbyte[, ][] s_11 = new sbyte[, ][]{{new sbyte[]{-89}}};
    static long s_33 = 9047189397625449986L;
    public static void Main()
    {
        char vr123 = (char)(byte)(s_33 ^ s_11[0, 0][0]);
        System.Console.WriteLine((int)vr123);
    }
}
