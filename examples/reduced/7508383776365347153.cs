// Generated by Fuzzlyn on 2018-06-04 00:31:50
// Seed: 7508383776365347153
// Reduced from 3.8 KB to 0.4 KB
// Debug: Outputs 193
// Release: Outputs 209
class C0
{
    public uint F1;
    public C0(uint f1)
    {
        F1 = f1;
    }
}

public class Program
{
    static long[] s_1 = new long[]{1L};
    public static void Main()
    {
        var vr8 = new int[][]{new int[]{478026498}};
        C0 vr9 = new C0(1864725457U);
        s_1[0] = (byte)vr9.F1 & (vr9.F1 % vr8[0][0]);
        System.Console.WriteLine(s_1[0]);
    }
}
