// Generated by Fuzzlyn on 2018-06-03 22:59:11
// Seed: 15247755908653636817
// Reduced from 1.4 KB to 0.2 KB
// Debug: Outputs 3343823881
// Release: Outputs 59028489
public class Program
{
    public static void Main()
    {
        uint[] vr3 = new uint[]{2683182595U};
        ulong vr4 = (ushort)vr3[0] * vr3[0];
        System.Console.WriteLine(vr4);
    }
}