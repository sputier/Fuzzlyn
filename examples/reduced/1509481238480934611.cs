// Generated by Fuzzlyn on 2018-06-03 22:56:25
// Seed: 1509481238480934611
// Reduced from 61.3 KB to 0.2 KB
// Debug: Outputs 65535
// Release: Outputs -1
public class Program
{
    static sbyte[] s_1 = new sbyte[]{-1};
    public static void Main()
    {
        byte vr89 = 36;
        var vr90 = (ushort)(s_1[0] | vr89);
        int vr91 = vr90;
        System.Console.WriteLine(vr91);
    }
}