// Generated by Fuzzlyn on 2018-06-04 00:24:43
// Seed: 709216038796959191
// Reduced from 372.7 KB to 0.4 KB
// Debug: Outputs 65529
// Release: Outputs 0
public class Program
{
    static long s_5 = 7984232355135152056L;
    static char s_34 = 'Q';
    static short[] s_41 = new short[]{32767};
    static short[] s_80 = new short[]{-1};
    public static void Main()
    {
        s_41 = s_80;
        s_34 = (char)((char)(1U | s_41[0]) / (short)s_5);
        System.Console.WriteLine((int)s_34);
    }
}
