// Generated by Fuzzlyn on 2018-06-03 22:46:11
// Seed: 143450024429929197
// Reduced from 1.8 KB to 0.3 KB
// Debug: 
// Release: 
public class Program
{
    public static void Main()
    {
        var vr2 = new ulong[]{16354872395143611726UL};
        M1(vr2);
    }

    static byte M1(ulong[] arg0)
    {
        arg0[0] = (((arg0[0] | 1) | 1) / ((65534 & (uint)(0 & arg0[0])) | 1));
        return 1;
    }
}