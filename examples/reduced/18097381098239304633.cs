// Generated by Fuzzlyn on 2018-06-03 23:26:28
// Seed: 18097381098239304633
// Reduced from 51.6 KB to 0.2 KB
// Debug: Outputs 255
// Release: Outputs 65535
public class Program
{
    static sbyte s_2 = 0;
    public static void Main()
    {
        s_2 = -2;
        byte vr60 = (byte)(1U | s_2);
        ushort vr62 = vr60;
        System.Console.WriteLine(vr62);
    }
}