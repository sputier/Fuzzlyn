// Generated by Fuzzlyn on 2018-06-03 23:44:05
// Seed: 3450472575536155787
// Reduced from 48.5 KB to 0.3 KB
// Debug: Outputs 50538
// Release: Outputs 4294952298
public class Program
{
    public static void Main()
    {
        var vr70 = new short[, ]{{-14998}};
        short vr76 = vr70[0, 0];
        ulong vr77 = (char)(1U * vr76);
        uint vr68 = (uint)vr77;
        System.Console.WriteLine(vr68);
    }
}