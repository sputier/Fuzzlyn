// Generated by Fuzzlyn on 2018-06-03 23:49:01
// Seed: 4059797942274755869
// Reduced from 12.3 KB to 0.3 KB
// Debug: Outputs 1004038009
// Release: Outputs 121
class C0
{
    public int F3;
    public sbyte F4;
    public C0(int f3)
    {
        F3 = f3;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr28 = new C0(1004038009);
        vr28.F4 = (sbyte)vr28.F3;
        vr28.F3 = vr28.F3;
        System.Console.WriteLine(vr28.F3);
    }
}
