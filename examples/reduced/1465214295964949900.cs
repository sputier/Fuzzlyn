// Generated by Fuzzlyn on 2018-06-03 22:50:39
// Seed: 1465214295964949900
// Reduced from 67.6 KB to 0.2 KB
// Debug: Outputs 255
// Release: Outputs -1
public class Program
{
    public static void Main()
    {
        sbyte[] vr81 = new sbyte[]{-1};
        var vr82 = (byte)(vr81[0] / (uint)1);
        System.Console.WriteLine((int)vr82);
    }
}
