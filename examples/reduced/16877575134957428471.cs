// Generated by Fuzzlyn on 2018-06-03 23:12:55
// Seed: 16877575134957428471
// Reduced from 12.8 KB to 0.3 KB
// Debug: Outputs 65534
// Release: Outputs -2
public class Program
{
    static byte s_1 = 254;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        var vr31 = (char)(254 | (sbyte)M8());
        int vr34 = vr31;
        System.Console.WriteLine(vr34);
    }

    static byte M8()
    {
        return s_1;
    }
}
