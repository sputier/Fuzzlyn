// Generated by Fuzzlyn on 2018-06-04 00:48:39
// Seed: 8401826608606535580
// Reduced from 178.0 KB to 0.2 KB
// Debug: Outputs 65458
// Release: Outputs -78
public class Program
{
    static sbyte s_15 = -78;
    public static void Main()
    {
        byte vr119 = (byte)(1L * s_15);
        var vr115 = (char)vr119;
        System.Console.WriteLine((int)vr115);
    }
}
