// Generated by Fuzzlyn on 2018-06-03 22:03:35
// Seed: 10187462581749713401
// Reduced from 186.7 KB to 0.2 KB
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
public class Program
{
    public static void Main()
    {
        var vr171 = new ushort[]{65535};
        ushort vr173 = vr171[0];
        var vr174 = 'N' % ((35815 / vr173) | 1);
    }
}
