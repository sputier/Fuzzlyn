// Generated by Fuzzlyn on 2018-06-04 00:27:39
// Seed: 7227943060736207105
// Reduced from 5.2 KB to 0.2 KB
// Debug: Outputs 41308
// Release: Outputs 4294943068
public class Program
{
    public static void Main()
    {
        var vr12 = new short[]{-24228};
        ushort vr23 = (ushort)(vr12[0] / 1L);
        long vr18 = vr23;
        System.Console.WriteLine(vr18);
    }
}