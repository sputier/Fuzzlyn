// Generated by Fuzzlyn on 2018-06-03 22:40:27
// Seed: 1374585756289470858
// Reduced from 131.1 KB to 0.4 KB
// Debug: Prints 1 line(s)
// Release: Prints 0 line(s)
public class Program
{
    static sbyte[, ] s_18 = new sbyte[, ]{{-40}};
    static int s_22 = -10;
    static int s_23 = 1127640667;
    public static void Main()
    {
        s_23 = -10;
        bool vr115 = (ushort)(s_18[0, 0] ^ 1) > s_23;
        if (vr115)
        {
            System.Console.WriteLine(s_22);
        }
        else
        {
        }
    }
}
