// Generated by Fuzzlyn on 2018-06-03 23:28:57
// Seed: 1865869368579171093
// Reduced from 111.8 KB to 0.3 KB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ushort F0;
    public uint F4;
    public C0()
    {
    }
}

public class Program
{
    static C0[, ] s_17 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        char vr120 = (char)((0 & s_17[0, 0].F0) % (s_17[0, 0].F4 | 1));
    }
}
