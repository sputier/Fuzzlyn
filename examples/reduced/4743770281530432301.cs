// Generated by Fuzzlyn on 2018-06-03 23:54:23
// Seed: 4743770281530432301
// Reduced from 0.5 KB to 0.2 KB
// Debug: Outputs -114361
// Release: Outputs -131069
public class Program
{
    public static void Main()
    {
        ushort[] vr0 = new ushort[]{38619};
        long vr1 = 16710 | ((4294967294U * vr0[0]) / -32768);
        System.Console.WriteLine(vr1);
    }
}