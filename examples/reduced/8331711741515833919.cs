// Generated by Fuzzlyn on 2018-06-04 00:44:14
// Seed: 8331711741515833919
// Reduced from 13.3 KB to 0.2 KB
// Debug: Outputs 610
// Release: Outputs -79
public class Program
{
    static short s_1 = -7512;
    public static void Main()
    {
        s_1 = (short)((ushort)(s_1 ^ 0U) / '_');
        System.Console.WriteLine(s_1);
    }
}
