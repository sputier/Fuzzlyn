// Generated by Fuzzlyn on 2018-06-03 23:48:04
// Seed: 3816300528977001505
// Reduced from 189.3 KB to 0.2 KB
// Debug: Outputs False
// Release: Outputs True
public class Program
{
    static uint s_23 = 1232329959U;
    static short s_32 = -10;
    public static void Main()
    {
        bool vr200 = (ushort)(1L | s_32) > s_23;
        System.Console.WriteLine(vr200);
    }
}
