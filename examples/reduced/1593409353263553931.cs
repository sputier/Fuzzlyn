// Generated by Fuzzlyn on 2018-06-03 23:02:17
// Seed: 1593409353263553931
// Reduced from 32.2 KB to 0.3 KB
// Debug: Outputs 203
// Release: Outputs -53
public class Program
{
    static sbyte[] s_2 = new sbyte[]{1};
    static int[] s_5 = new int[]{10};
    public static void Main()
    {
        s_2[0] = -53;
        byte vr49 = (byte)(0U ^ s_2[0]);
        s_5[0] = vr49;
        System.Console.WriteLine(s_5[0]);
    }
}
