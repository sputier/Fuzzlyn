// Generated by Fuzzlyn on 2018-06-03 23:56:48
// Seed: 4875637055389468069
// Reduced from 1.7 KB to 0.2 KB
// Debug: Outputs 49101
// Release: Outputs 4294950861
public class Program
{
    static short s_2 = -16436;
    public static void Main()
    {
        ulong vr2 = (char)(1U ^ s_2);
        System.Console.WriteLine(vr2);
    }
}
