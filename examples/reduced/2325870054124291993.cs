// Generated by Fuzzlyn on 2018-06-03 23:32:06
// Seed: 2325870054124291993
// Reduced from 60.3 KB to 1.0 KB
// Debug: Outputs 255
// Release: Outputs 4294967295
class C0
{
    public sbyte F3;
    public C0(sbyte f3)
    {
        F3 = f3;
    }
}

class C1
{
    public uint F7;
    public C1()
    {
    }
}

struct S1
{
    public C0 F0;
    public ulong F1;
    public ushort F2;
    public sbyte F3;
    public sbyte F4;
    public char F5;
    public ushort F6;
    public bool F7;
    public S1(C0 f0, ulong f1, ushort f2, sbyte f3, sbyte f4, char f5, ushort f6, bool f7)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
    }
}

public class Program
{
    static C1 s_4 = new C1();
    static S1 s_5 = new S1(new C0(126), 2UL, 1, -128, -2, '#', 45681, false);
    public static void Main()
    {
        s_5 = new S1(new C0(-1), 12932572674711728348UL, 10611, 1, 1, 't', 1, false);
        var vr55 = s_5.F0;
        sbyte vr58 = 66;
        byte vr59 = (byte)((uint)vr58 | vr55.F3);
        s_4.F7 = vr59;
        System.Console.WriteLine(s_4.F7);
    }
}