// Generated by Fuzzlyn on 2018-06-04 00:24:40
// Seed: 7085159473545837291
// Reduced from 259.3 KB to 0.4 KB
// Debug: Outputs 76
// Release: Outputs 120
public class Program
{
    static char[] s_4 = new char[]{'L'};
    static sbyte s_5 = 0;
    static uint[] s_6 = new uint[]{4054604985U};
    public static void Main()
    {
        s_5 = -100;
        bool vr232 = s_6[0] <= (byte)(s_5 | (long)0);
        if (vr232)
        {
            s_4[0] = 'x';
        }
        else
        {
        }

        System.Console.WriteLine((int)s_4[0]);
    }
}