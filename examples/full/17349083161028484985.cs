// Generated by Fuzzlyn on 2018-06-03 23:20:32
// Seed: 17349083161028484985
class C0
{
    public sbyte F0;
    public int F1;
    public sbyte F2;
    public char F3;
    public sbyte F4;
    public short F5;
    public bool F6;
    public byte F7;
    public short F8;
    public char F9;
    public C0(sbyte f0, int f1, sbyte f2, char f3, sbyte f4, short f5, bool f6, byte f7, short f8, char f9)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
        F7 = f7;
        F8 = f8;
        F9 = f9;
    }
}

struct S0
{
    public short F0;
    public int F1;
    public byte F2;
    public char F3;
    public S0(short f0, int f1, byte f2, char f3)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

class C1
{
    public ushort F0;
    public S0 F1;
    public C0 F2;
    public int F3;
    public bool F4;
    public S0 F5;
    public long F6;
    public char F7;
    public C1(ushort f0, S0 f1, C0 f2, int f3, bool f4, S0 f5, long f6, char f7)
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
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        {
            S0 var0 = new S0(32766, -805474427, 13, '\'');
            byte var1 = var0.F2;
            var0.F3 = var0.F3;
            M1(57628);
            var0.F0 = var0.F0;
            if ((ushort)(var1 - (short)M1((ushort)(-9223372036854775807L & M1((ushort)M1(60634))))) < 0U)
            {
                M3(var0.F2, 1434176409002868847L, 2677268919U, var0.F0);
            }
            else
            {
                var0.F0 = var0.F0;
                var0.F2 = var1;
            }

            bool var2 = false;
        }

        C0 var3 = new C0(-66, -1370542185, -116, 'B', 26, -20346, false, 231, 11653, 'j');
    }

    static sbyte M1(ushort arg0)
    {
        M2(new S0[][, ]{new S0[, ]{{new S0(16208, 2147483647, 45, 'l'), new S0(1, -839018554, 0, 'F'), new S0(-16312, 0, 235, '\''), new S0(-32768, -2147483648, 1, 'i'), new S0(9533, 1, 254, '6'), new S0(24488, -10, 103, 'C'), new S0(-4171, 940045966, 1, '$'), new S0(26659, 285958800, 255, '7')}}, new S0[, ]{{new S0(-17807, 1228059411, 0, 'q'), new S0(30875, -1, 255, '-'), new S0(-4843, -1553070153, 33, 'Q'), new S0(-32767, 2147483646, 0, 'q'), new S0(1, 754485514, 160, 'P'), new S0(1, 758814481, 255, 'z'), new S0(32766, 280050834, 73, 'B'), new S0(-32768, 2147483646, 0, '=')}}, new S0[, ]{{new S0(-20156, -1970642750, 254, '>'), new S0(32767, 1666160916, 169, '7'), new S0(-32767, 0, 1, 'q'), new S0(32766, -1111559120, 101, 'j'), new S0(-2874, 2147483646, 2, 's'), new S0(-7687, -1690133310, 1, 'y'), new S0(27847, -1827970881, 254, 'x'), new S0(27216, 2147483647, 75, 'P')}}, new S0[, ]{{new S0(2, -1072041900, 91, 'q'), new S0(1, 0, 66, 't'), new S0(32766, 714641027, 146, '/'), new S0(1, 1155078547, 0, 'h'), new S0(-25828, 1, 0, '='), new S0(32767, 0, 1, '0'), new S0(12368, 1176365171, 89, 'Y'), new S0(32766, -1630775227, 10, ',')}}, new S0[, ]{{new S0(29197, -1419560041, 1, '%'), new S0(2, 99862926, 254, ' '), new S0(-10846, -2147483647, 70, 'R'), new S0(20570, -972173385, 10, 'M'), new S0(32767, 2, 212, 'R'), new S0(-1, 288558831, 1, 'c'), new S0(-13531, -2, 1, '#'), new S0(24179, 871604257, 1, 'K')}}, new S0[, ]{{new S0(18070, -10, 173, '2'), new S0(20589, 1196477239, 255, 'S'), new S0(15544, 2, 240, 'c'), new S0(1902, 2147483647, 1, 'D'), new S0(-2, 2147483646, 0, ' '), new S0(-32768, 0, 0, 'M'), new S0(2, -1583590752, 1, 'H'), new S0(0, 0, 101, 'q')}}, new S0[, ]{{new S0(-30875, 1, 254, '\''), new S0(3611, 901853066, 0, 'A'), new S0(8119, -2147483647, 10, 'm'), new S0(-11943, -623530110, 99, 'r'), new S0(1, 1672496054, 101, ' '), new S0(0, -865895619, 240, 'i'), new S0(1576, 91879097, 1, '#'), new S0(-29903, 1, 0, ']')}}});
        arg0 = arg0;
        if (false)
        {
            arg0 = arg0;
            byte var0 = 1;
        }
        else
        {
            long var1 = -7774036245855716349L;
        }

        return 127;
    }

    static bool M2(S0[][, ] arg0)
    {
        M3(arg0[0][0, 0].F2, -6397858072214229724L, (uint)(arg0[0][0, 0].F3 & 0), arg0[0][0, 0].F0);
        return false;
    }

    static C1[, ][] M3(byte arg0, long arg1, uint arg2, short arg3)
    {
        arg3 = arg3;
        char var0 = '4';
        return new C1[, ][]{{new C1[]{new C1(65535, new S0(1, 898615678, 114, 'W'), new C0(18, 2147483646, 0, 'I', -127, -5128, true, 136, 0, 'Y'), -1084105523, false, new S0(8020, 1, 237, 'K'), -9223372036854775808L, '.')}, new C1[]{new C1(46171, new S0(-2, -2147483647, 21, 'Y'), new C0(76, 41933763, -128, 's', 31, 32766, false, 183, 0, 'V'), 263202596, true, new S0(1, -1999608386, 1, 's'), 6120459180998492110L, 'X'), new C1(10, new S0(-32768, 2147483647, 255, 'X'), new C0(-127, 1399737656, -26, 'B', -128, 2641, false, 1, -19403, 'I'), 2147483647, false, new S0(2592, -1137605260, 77, '0'), 9223372036854775807L, 'n')}, new C1[]{new C1(64847, new S0(32766, 2147483647, 255, 'i'), new C0(0, -2003965143, 0, 'W', 108, -12556, true, 197, 1, 'l'), 2147483647, true, new S0(-7100, 533331574, 153, 'f'), -403772976623053767L, 'i')}, new C1[]{new C1(29245, new S0(0, -1422691140, 1, '\\'), new C0(126, 2147483647, 81, '6', -8, 3315, true, 255, -32767, '9'), -426776202, false, new S0(-32768, -2112342337, 1, 'j'), 0L, '&')}, new C1[]{new C1(50945, new S0(-30856, -1072748031, 164, 'o'), new C0(16, 2147483647, 126, '@', 2, -21273, true, 170, -31207, '\\'), -453590505, false, new S0(1, -2147483648, 192, 'S'), 723116255047698518L, 's'), new C1(17245, new S0(-10, -657549046, 42, 'C'), new C0(-70, -10, 0, 'Q', -127, -20863, true, 40, 0, ','), -1494340273, false, new S0(-32767, -1261510476, 251, '%'), -9223372036854775808L, 't')}, new C1[]{new C1(3745, new S0(-32768, 753950210, 254, 't'), new C0(-118, 2147483646, 0, 't', -17, -32427, true, 31, -6522, 'q'), -1, true, new S0(5895, -1887922666, 1, 'b'), -9223372036854775808L, 'd'), new C1(65535, new S0(-32768, 830772105, 0, 'W'), new C0(33, 184180141, 48, 't', 127, 0, true, 112, 23999, 'C'), -1, false, new S0(-32767, 704128732, 1, 't'), 1L, 'T')}}};
    }
}