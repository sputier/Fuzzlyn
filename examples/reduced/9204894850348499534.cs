// Generated by Fuzzlyn on 2018-06-04 01:08:05
// Seed: 9204894850348499534
// Reduced from 59.5 KB to 0.4 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static ushort[, ] s_1 = new ushort[, ]{{15788}};
    public static void Main()
    {
        var vr47 = 1542819550U;
        var vr48 = (byte)((s_1[0, 0] & 0) | s_1[0, 0]);
        M13(vr47, vr48);
    }

    static int[] M13(uint arg3, byte arg4)
    {
        System.Console.WriteLine(arg3);
        return new int[]{-2135707777};
    }
}