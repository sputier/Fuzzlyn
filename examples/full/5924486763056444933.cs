// Generated by Fuzzlyn on 2018-06-04 00:09:19
// Seed: 5924486763056444933
struct S0
{
    public uint F0;
    public byte F1;
    public byte F2;
    public ushort F3;
    public short F4;
    public S0(uint f0, byte f1, byte f2, ushort f3, short f4)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
    }
}

class C0
{
    public bool F0;
    public short F1;
    public char F2;
    public int F3;
    public ulong F4;
    public S0 F5;
    public ushort F6;
    public C0(bool f0, short f1, char f2, int f3, ulong f4, S0 f5, ushort f6)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
        F4 = f4;
        F5 = f5;
        F6 = f6;
    }
}

class C1
{
    public ushort F0;
    public long F1;
    public uint F2;
    public C0 F3;
    public C0 F4;
    public ulong F5;
    public short F6;
    public C0 F7;
    public uint F8;
    public long F9;
    public C1(ushort f0, long f1, uint f2, C0 f3, C0 f4, ulong f5, short f6, C0 f7, uint f8, long f9)
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

public class Program
{
    static short[, ] s_1 = new short[, ]{{1, 0, -32768, -21450, -21921, -32767}, {21180, -26727, -9996, 0, 4273, -1494}, {-32767, 1, 31869, -19933, 0, -21691}, {28280, 8181, -21917, 1, -12116, -32767}, {16542, 6730, 14260, 32258, 2, 10}, {-10, -2999, -32768, 5175, 22508, 13523}};
    static ulong s_2 = 2UL;
    static sbyte s_3 = 1;
    static C0 s_4 = new C0(false, -18211, 'p', -1, 1UL, new S0(1597052299U, 179, 129, 0, 1), 18142);
    static C0 s_5 = new C0(true, 13265, 'K', 1711307230, 1UL, new S0(4294967295U, 63, 98, 0, 10), 1);
    static uint s_6 = 4294967294U;
    static ulong[] s_7 = new ulong[]{1UL, 1UL, 1UL};
    static short s_8 = 32767;
    static uint s_9 = 3072620644U;
    static sbyte[] s_10 = new sbyte[]{-127, 101, 47, 1, 50, 97, -127, -66, 0, -127};
    static int s_11 = 1;
    static S0 s_12 = new S0(1U, 71, 0, 26721, -32768);
    static C0 s_13 = new C0(true, -18506, 's', 2, 1UL, new S0(4294967295U, 58, 2, 32841, 15166), 1);
    static char s_14 = '.';
    static char s_15 = 'B';
    static short s_16 = -15550;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        int var0 = 121 + (short)(4647353749438837497UL | (15056385698209854188UL | (ushort)(3215085676U % (char)((char)(0 ^ M1()) | 1))));
        var0 = var0;
        if (false)
        {
            var0 = (int)M1();
            var0 = var0++;
            M1();
            if (M2())
            {
                s_5.F0 = s_4.F0;
                {
                    s_4.F5.F2 = 119;
                }

                s_5.F5.F2 = s_4.F5.F2;
                s_15 = ']';
                char var1 = (char)M5();
                {
                    M17(s_4.F3, s_3, 9223372036854775806L, M13(), -2189883408851215864L, 0UL);
                    if (s_13.F0)
                    {
                        s_13.F5 = new S0(0U, 1, 21, 0, 21030);
                    }
                    else
                    {
                        M7(s_13.F5.F0++);
                    }

                    ulong var2 = s_7[0];
                }

                M3();
                s_16 = s_5.F5.F4++;
            }

            s_9 = 749218805U;
            if (s_13.F0)
            {
                s_13.F5.F4 = s_5.F5.F4;
            }
            else
            {
                s_3 = s_3;
                S0 var3 = s_4.F5;
                s_5 = s_4;
            }

            s_3 = 126;
        }

        s_2 = (ulong)((char)(s_1[0, 0] - s_10[0]) / (long)(1L | 1));
        {
            if (s_5.F0)
            {
                char var4 = (char)((long)(1UL & s_7[0]) ^ (long)M17(s_13.F3, s_10[0], 2L, 29149, (long)M13(), s_7[0]));
                s_13 = s_4;
                M5();
                s_4.F4 = s_4.F4;
                int[] var5 = new int[]{0, 180713608, 830767495, 974210171};
            }
        }

        if (false)
        {
            s_5.F1 = s_5.F5.F4;
        }
    }

    static char M1()
    {
        return '+';
    }

    static bool M2()
    {
        sbyte var0 = -128;
        if (true)
        {
            var0 = var0;
            var0 = var0;
        }
        else
        {
            {
                var0 = var0;
                {
                    ushort var1 = 14451;
                }
            }
        }

        M3();
        if (s_5.F0)
        {
            s_5.F5 = M3();
            M3();
            M10();
            if (s_5.F0)
            {
                short[] var2 = new short[]{-12508, -1, -31110, 0};
                s_5.F1 = s_4.F5.F4;
                S0 var3 = s_5.F5;
            }

            s_5.F0 = true;
            if (s_4.F0 | s_4.F0)
            {
                if (s_5.F0)
                {
                    M17(-2989 + var0, s_3, (long)(s_4.F4 * s_6), s_5.F1++, M11(var0), 9269098891194345058UL);
                }
            }

            {
                if (true)
                {
                    if (s_5.F0)
                    {
                        if (s_5.F0)
                        {
                            sbyte var4 = s_3;
                            {
                                s_8 = (short)M18(-626879556, new C0(false, 0, '"', 2147483646, 12147071858484560560UL, new S0(3530636580U, 1, 0, 65535, 1), 0), new C0[]{new C0(false, -10, 'r', -900469316, 18446744073709551615UL, new S0(1231703887U, 1, 2, 2518, -30738), 23394), new C0(false, -32768, 's', -1, 0UL, new S0(1U, 255, 160, 29900, -1), 27643), new C0(true, 10777, ')', 946571901, 16041067738584050179UL, new S0(4294967295U, 228, 131, 65534, -11457), 19733), new C0(false, -20833, '9', -2147483647, 0UL, new S0(4294967294U, 10, 43, 3908, 5348), 10), new C0(false, 4507, 'Q', -2, 0UL, new S0(0U, 255, 14, 1, 32767), 22190), new C0(false, 1, '0', -2147483647, 0UL, new S0(1198322212U, 119, 1, 0, -32768), 22606), new C0(true, 0, 'Z', -1939223881, 18446744073709551615UL, new S0(1U, 1, 115, 48994, 4881), 0), new C0(true, 20225, 'q', 166381800, 2UL, new S0(4265007501U, 106, 0, 15178, -26978), 24640), new C0(true, 11598, '!', 0, 18446744073709551615UL, new S0(1U, 1, 144, 65535, -28182), 10271)}, new C0(true, -18117, 'W', 557608534, 1UL, new S0(0U, 15, 58, 65535, 18845), 17475), (uint)M19(0L, new C0(true, 21189, 'z', 1, 0UL, new S0(0U, 241, 24, 1, 30306), 1), new C0(false, -3547, '6', 2147483647, 1UL, new S0(0U, 50, 1, 0, -10467), 15856), s_5.F0, s_4.F0, M20(), new char[]{'B', '>'}));
                                uint var5 = M21();
                                s_5.F5.F4 = s_5.F1;
                            }

                            bool var6 = s_4.F0;
                            s_4.F5.F4 = s_8++;
                            if (s_5.F0)
                            {
                                {
                                    s_4.F0 = s_4.F0;
                                }

                                M20();
                            }

                            s_4.F4 &= s_4.F4;
                            s_4.F3 = -743452458;
                            int var7 = s_5.F3;
                            M17(var7, s_3, (long)M4(s_5, M12(var6, s_4.F5.F3, s_5.F4, s_4.F0, s_1[0, 0]--, (long)M21()), s_5.F4, var6, s_4.F5, s_4.F2, new bool[]{true, true}, new C1(1, 4124218784842454853L, 906986324U, new C0(true, 32767, '[', 1273855153, 10395088171180569896UL, new S0(2453007490U, 117, 148, 198, -22833), 65535), new C0(false, 32766, 'W', 388182158, 18446744073709551615UL, new S0(0U, 74, 255, 1, 1), 41238), 15933545930239837081UL, -16780, new C0(true, 0, 'K', 553076235, 1UL, new S0(1682416960U, 5, 219, 34474, -32768), 26181), 2U, 5201701858169675038L), new C1(65534, 9223372036854775807L, 388813555U, new C0(true, -10, ':', -1073955729, 0UL, new S0(2011367051U, 191, 38, 64784, 14274), 23525), new C0(true, 13314, ',', 16841549, 18446744073709551615UL, new S0(4294967294U, 129, 0, 1, 2), 18693), 0UL, 32751, new C0(false, 1, 'K', 1723044105, 0UL, new S0(344982413U, 0, 132, 0, 32766), 16664), 774771537U, 1L), s_5.F5), (short)(-15631 - s_5.F2--), (long)(s_8-- / (short)(s_4.F5.F4 | 1)), s_5.F4);
                            s_5.F5.F3 = 1;
                        }
                        else
                        {
                            s_8 = 25499;
                            s_1 = s_1;
                            s_4 = s_4;
                            if (s_5.F0)
                            {
                                s_9 = s_5.F5.F0;
                            }
                            else
                            {
                                return s_4.F0;
                            }

                            s_4.F6 = s_5.F6;
                            if (s_5.F0)
                            {
                                s_4.F1 = s_1[0, 0]--;
                            }
                            else
                            {
                                s_5.F0 = s_5.F0;
                                s_4.F1 = s_5.F5.F4;
                                s_2 = s_5.F4;
                            }
                        }

                        if (true)
                        {
                            if (s_4.F0)
                            {
                                M9(var0);
                            }
                            else
                            {
                                M10();
                                s_4.F5.F2 %= (byte)(s_5.F5.F2 | 1);
                            }

                            s_10 = s_10;
                            s_4.F2 = s_5.F2;
                            s_11 = s_11++;
                            s_3 = 99;
                            s_4.F4 = s_4.F4;
                            s_8 = (short)M6(s_4.F2++, 65535, new C0[]{new C0(true, 16808, 'D', -1478587822, 17855806281227479375UL, new S0(4294967295U, 197, 254, 24783, -17229), 1)}, 32, s_5.F2--);
                            s_3 = s_3;
                            s_7 = new ulong[]{8036965614040868858UL, 0UL, 1503584953079844290UL, 10884212719125355015UL, 8873875196172775352UL, 8991449841023703229UL, 12220984840266172868UL, 17305049537121168651UL};
                        }
                    }

                    s_4.F2 = s_4.F2;
                }
            }

            s_3 &= s_3;
            s_12 = new S0(1U, 1, 173, 1, 0);
        }
        else
        {
            s_4.F3 = -1;
            s_13 = s_4;
            s_8 = s_5.F1;
            s_14 = s_14++;
            S0[][] var8 = new S0[][]{new S0[]{new S0(1U, 0, 7, 1, 6381), new S0(618863486U, 68, 254, 0, 1)}, new S0[]{new S0(2498736670U, 2, 1, 35017, -4865), new S0(887271337U, 255, 95, 39414, 15920), new S0(2946838169U, 0, 254, 65535, 0), new S0(10U, 74, 149, 1, -4010), new S0(4294967294U, 203, 2, 33929, 18031), new S0(1U, 0, 1, 14605, 32766), new S0(1681723868U, 43, 1, 16108, 0)}, new S0[]{new S0(4294967295U, 97, 81, 1, 10), new S0(249814111U, 102, 0, 6895, -5495), new S0(2681132737U, 0, 169, 6092, -7842), new S0(1U, 1, 1, 41452, 0), new S0(1U, 104, 162, 925, -32767), new S0(1542528104U, 32, 185, 38762, -17020), new S0(2528635202U, 1, 0, 65535, 7775)}, new S0[]{new S0(1U, 234, 1, 786, 29110), new S0(2474462644U, 180, 255, 1, -13684), new S0(3535695076U, 34, 97, 1, -32768), new S0(1U, 20, 231, 65535, 12447), new S0(1U, 190, 59, 1, 3772)}, new S0[]{new S0(1499532939U, 144, 194, 65534, 32767)}};
            s_2 = s_13.F4;
        }

        return true & s_5.F0;
    }

    static S0 M3()
    {
        char var0 = (char)(10053764118688675454UL | (uint)((byte)(0UL & M4(new C0(false, -32768, '<', -2, 3146397234095587140UL, new S0(599961015U, 152, 1, 10, -32767), 32416), new C1(10, 1088350877887954409L, 12215321U, new C0(false, -14718, ')', 402436508, 7081229664675193619UL, new S0(4294967294U, 227, 0, 10, -32767), 0), new C0(false, -30049, '*', -2, 10UL, new S0(0U, 0, 224, 4032, 18883), 0), 18446744073709551615UL, -23816, new C0(false, -32767, 'J', 2147483647, 18446744073709551615UL, new S0(892485545U, 255, 254, 0, -32768), 1), 3931257591U, -9223372036854775807L), 1UL, true, new S0(2576167357U, 62, 0, 20181, 0), (char)('h' % (short)(s_1[0, 0]-- | 1)), new bool[]{true, true, false, false}, new C1(13456, 1L, 1U, new C0(false, 1, 'a', 1718257693, 18446744073709551614UL, new S0(829453091U, 180, 1, 1, 1), 0), new C0(false, -13402, 'u', -678797917, 11473782093804193404UL, new S0(2U, 188, 12, 22871, -15920), 26125), 17341145606491911892UL, 16497, new C0(true, -32768, 'h', -1725534432, 595509960329415842UL, new S0(3790119782U, 0, 6, 6606, 0), 37043), 0U, 1007276056128615996L), new C1(48350, 9223372036854775806L, 1320637136U, new C0(false, 26015, ' ', 933359002, 0UL, new S0(4294967295U, 138, 1, 1, -7537), 46561), new C0(false, 32766, '|', -2105027118, 7050319818413181793UL, new S0(4294967294U, 98, 41, 10, -32768), 2), 17392802917887186568UL, 11950, new C0(true, -32325, '|', 2147483647, 18446744073709551615UL, new S0(1U, 147, 10, 1, 1), 13860), 805569661U, 6796691955286816625L), new S0(1034999632U, 0, 254, 0, -31810))) * 66));
        if (true)
        {
            short var1 = (short)(9223372036854775807L & (int)M4(new C0(true, 0, '*', 416637000, 1UL, new S0(259342660U, 138, 1, 60007, -32767), 58317), new C1(1, 1L, 2229653215U, new C0(true, 10223, 's', 1878302905, 3471290370530887949UL, new S0(4209035187U, 87, 89, 8040, 32767), 0), new C0(true, 0, 'r', 2147483647, 12283648511315877323UL, new S0(1684824144U, 137, 1, 0, -30284), 1), 18446744073709551615UL, 15612, new C0(true, -10, '\'', -1557438582, 1588118155268087085UL, new S0(3420439878U, 167, 1, 0, -10), 26834), 2043715546U, 3186399444327078561L), 732692265929976645UL, (int)(var0 * M5()) != (long)M16(s_4.F0), new S0(0U, 215, 112, 65534, 29195), (char)(s_4.F2 + 3478877286052128382L), new bool[]{false, false, false, false, false, true}, M12(9223372036854775807L < -6844851239041937267L, (ushort)(s_5.F5.F4 % (short)(s_8 | 1)), 0UL, s_4.F0, s_5.F5.F4--, 9223372036854775806L), new C1(32515, 9223372036854775806L, 1U, new C0(true, -32768, 'J', 0, 10200699395422463082UL, new S0(1U, 1, 82, 1, -1), 0), new C0(true, -21741, '1', 1, 15049335675485304170UL, new S0(0U, 151, 7, 0, 6245), 1), 10UL, -32768, new C0(true, -1, 'n', 329247315, 1UL, new S0(3029949683U, 10, 255, 65534, 0), 5753), 4294967295U, 0L), new S0(844049759U, 10, 0, 34510, 10)));
        }
        else
        {
            {
                s_5.F5.F4 = (short)M10();
                M6('!', 550, new C0[]{new C0(true, 0, 'd', 2147483647, 15598373809381218133UL, new S0(4294967295U, 23, 197, 4901, -4302), 39327), new C0(true, -14784, 'd', 1317145445, 1UL, new S0(927684139U, 53, 163, 35508, -26364), 0), new C0(false, -20036, '>', 0, 2UL, new S0(1278157723U, 13, 0, 1, 32766), 18449), new C0(false, 32767, ';', 0, 17221887889311797651UL, new S0(1U, 213, 0, 30070, 32766), 1), new C0(true, 1, '<', 1, 0UL, new S0(1967785732U, 254, 225, 58932, 1), 1), new C0(false, 24281, 'f', 2147483646, 11832466428361910632UL, new S0(0U, 254, 141, 26951, 1), 0)}, 0, s_4.F2);
                s_5.F5.F1 = s_5.F5.F2;
                uint var2 = s_5.F5.F0;
                M13();
                S0 var3 = s_5.F5;
                M19((long)(s_2 - s_2), s_5, s_4, s_4.F0, s_4.F0, M20(), new char[]{'j', '@', 'Q', '#'});
                {
                    s_5.F1 = s_4.F1++;
                }
            }

            s_5.F0 = true;
        }

        s_5.F5 = s_4.F5;
        s_5.F5.F1 = s_4.F5.F1;
        if (s_5.F0)
        {
            s_9 = s_6;
            M6(var0, s_4.F6, new C0[]{new C0(false, 12709, ']', -1493883839, 11152649328118959472UL, new S0(1323115513U, 39, 255, 65534, -24489), 46063), new C0(false, 1671, 'N', 1877223166, 0UL, new S0(1U, 10, 0, 46428, -32767), 56543), new C0(true, 1, 'w', 2147483647, 18446744073709551615UL, new S0(3409576355U, 212, 229, 0, 32767), 65535), new C0(false, 10, 'E', -2147483647, 11419567556784956924UL, new S0(1026366889U, 72, 122, 0, 6722), 65534), new C0(true, -10, 'q', -2147483648, 15493293148822478329UL, new S0(605148684U, 168, 101, 1, -13519), 22172), new C0(true, 18366, '3', -2049702210, 1UL, new S0(0U, 102, 0, 7611, -24532), 2), new C0(true, 24121, 'D', 1094474166, 6341981759392153104UL, new S0(1U, 0, 28, 0, 10), 1)}, (byte)M15(), (char)M4(new C0(false, 1374, 'q', 248073742, 3264146938397272798UL, new S0(2742599432U, 255, 1, 0, 20729), 1), new C1(65535, 1784823253913270042L, 716395311U, new C0(false, 13762, '^', 303789801, 1UL, new S0(4294967295U, 103, 1, 25486, -19661), 60804), new C0(false, 32766, '{', 1672640746, 18446744073709551615UL, new S0(1U, 0, 166, 1, 32767), 12677), 0UL, -32767, new C0(false, 0, 'e', 2147483647, 10451672343961171532UL, new S0(4185922374U, 201, 220, 1, 7903), 1), 0U, 2112337884930691213L), s_5.F4, s_4.F0, new S0(261490429U, 1, 2, 4907, 0), 'K', new bool[]{false}, M12(true, s_4.F6, 18446744073709551615UL, s_5.F0, -10, -2184464341115608738L), M12(s_5.F0, s_4.F6, s_5.F4, s_5.F0, s_4.F1, (long)M16(true)), s_5.F5));
        }

        return s_5.F5;
    }

    static uint M4(C0 arg0, C1 arg1, ulong arg2, bool arg3, S0 arg4, char arg5, bool[] arg6, C1 arg7, C1 arg8, S0 arg9)
    {
        if (true)
        {
            S0 var0 = arg7.F4.F5;
            arg1.F3.F5.F4 = arg7.F4.F5.F4;
            s_1 = s_1;
            arg1.F1 = arg1.F9;
            arg7.F3.F5.F1 = var0.F1;
        }
        else
        {
            arg1.F2 = arg8.F2++;
            arg9 = arg0.F5;
            arg8.F3.F5 = new S0(38776295U, 205, 140, 65535, 0);
            arg1.F3.F5.F3 = 1;
        }

        return 3178297303U;
    }

    static uint M5()
    {
        {
            s_1 = s_1;
            if (false)
            {
                S0 var0 = new S0(0U, 173, 212, 65534, -7570);
            }
            else
            {
                s_1 = s_1;
                if ((2L < 1648321723U) || false)
                {
                    short var1 = s_1[0, 0];
                }

                if (true || false)
                {
                    s_1 = s_1;
                    s_1[0, 0] = -32768;
                    {
                        s_1[0, 0] = s_1[0, 0];
                        s_1 = s_1;
                        M6(s_4.F2, s_4.F5.F3, new C0[]{new C0(true, -14771, 'T', 641825064, 7832677510554696356UL, new S0(1933517179U, 155, 1, 45151, -188), 1), new C0(false, 14427, '2', 0, 7968583982209605584UL, new S0(2216351071U, 242, 1, 57854, 32766), 4208), new C0(true, 10, ' ', -555666307, 1UL, new S0(2599516417U, 149, 1, 56756, -24567), 45978), new C0(false, 16638, '4', 2147483647, 16076743774339281555UL, new S0(1002316915U, 231, 0, 18191, -32767), 0), new C0(false, -10475, 'u', 2147483646, 0UL, new S0(68541564U, 68, 0, 0, 32767), 0), new C0(false, -32767, 'J', 329152376, 18446744073709551615UL, new S0(0U, 34, 81, 0, 10), 38136), new C0(false, -2106, 'J', -95842534, 5011137700577687512UL, new S0(0U, 173, 254, 6805, 0), 18879)}, s_5.F5.F1, s_4.F2);
                        s_4.F5 = s_4.F5;
                        M17(137250695, s_3, (long)M14(s_4.F1), s_4.F5.F4, 1L, s_4.F4);
                    }

                    bool var2 = s_5.F0;
                    s_1[0, 0] += s_5.F5.F4;
                }
                else
                {
                    s_4.F5.F0 = (uint)M6('K', s_4.F5.F3, new C0[]{new C0(false, -19998, 'X', 813787185, 4398501841533316299UL, new S0(883175891U, 0, 1, 0, 2), 65534), new C0(false, -11405, 'h', 1245661059, 1UL, new S0(0U, 254, 1, 0, 32767), 33901), new C0(true, 1, 'V', 835115777, 11993950326562304947UL, new S0(629439755U, 63, 102, 0, 1), 19850), new C0(true, -193, '|', 834896905, 12056107563323220211UL, new S0(1542235460U, 117, 255, 0, 1), 1), new C0(false, -24725, '_', 1488847936, 14477935211261747728UL, new S0(0U, 254, 240, 0, -20446), 1), new C0(true, 13577, '5', 1143685999, 18446744073709551614UL, new S0(4294967295U, 124, 225, 1, 32767), 0), new C0(false, -15521, 'g', 1, 1UL, new S0(0U, 254, 1, 1, -11281), 1), new C0(true, 2717, 'i', -432030760, 0UL, new S0(4294967294U, 163, 1, 5376, 25633), 1), new C0(true, 0, '0', 105777829, 10UL, new S0(2106115108U, 255, 180, 2, -11491), 41712)}, M18((int)M17(s_5.F3, 10, (long)M6('8', s_5.F5.F3, new C0[]{new C0(false, -29428, 'o', -319804080, 0UL, new S0(0U, 47, 1, 2, -10), 65535), new C0(false, 1, 'f', -590398616, 10UL, new S0(4294967294U, 0, 0, 54233, 32767), 47126), new C0(false, 1, '!', -32631933, 4395004612054729669UL, new S0(2271743968U, 1, 199, 0, 11654), 40918), new C0(true, 32766, '9', 2147483646, 0UL, new S0(1U, 255, 67, 10, 32766), 3970), new C0(false, -2, 'h', -663717468, 2633149757705381890UL, new S0(2280251443U, 213, 225, 0, -1194), 25135), new C0(false, -31340, '[', -1593790392, 1UL, new S0(0U, 40, 6, 65535, 1), 65535), new C0(true, 9154, '`', -2147483647, 14443926553216273819UL, new S0(1642492129U, 203, 0, 4003, -7359), 20637)}, (byte)M15(), s_4.F2--), s_4.F5.F4, (long)(20016 / (byte)(s_5.F5.F2 | 1)), s_4.F4), s_4, new C0[]{new C0(false, -17032, 'V', 2147483646, 3342864594628141756UL, new S0(788744170U, 1, 1, 65535, 32767), 14082), new C0(false, 29767, 'A', 2147483647, 1UL, new S0(1U, 163, 255, 1, -22026), 2), new C0(false, 1, 'f', -1880232193, 1UL, new S0(3783208215U, 0, 2, 1, 0), 44412), new C0(true, 1, 'f', -13580818, 11880106351475611205UL, new S0(2328630096U, 209, 1, 0, 32767), 37093), new C0(true, -6596, 'b', -480837083, 18446744073709551614UL, new S0(2637258753U, 36, 255, 0, 2), 24579), new C0(true, 0, '|', 1, 18446744073709551615UL, new S0(4294967294U, 154, 96, 1, -32768), 30085), new C0(true, -13774, '7', 0, 12961371242093513296UL, new S0(0U, 10, 28, 12367, 27135), 0), new C0(true, -7329, 'S', 1640691078, 1UL, new S0(0U, 0, 254, 1, -16488), 1), new C0(false, 10712, 'V', 1421263637, 2087165564916433406UL, new S0(1U, 0, 1, 0, -20537), 32093)}, M9(s_3++), s_4.F5.F0), s_4.F2);
                    uint var3 = 1U;
                }

                s_2 = s_2;
            }

            s_5.F5.F2 = 98;
            s_4.F3 = s_5.F3;
            s_5.F5 = new S0(1U, 108, 1, 1, -32768);
            s_1 = new short[, ]{{10, 21706, 1, 1, 32766, -32767, 32767}, {2, 16775, -32768, 1, -2, -20138, 13561}, {-11803, 2, -10, -13133, 0, -19950, 1}, {-32767, 9766, -10, 2, 22435, -12665, -32767}, {18453, -10, 8037, 8033, 31955, 12640, 4882}};
        }

        s_5.F1 = s_4.F5.F4;
        if (true)
        {
            return s_4.F5.F0;
        }
        else
        {
            if (true)
            {
                s_4.F5.F3 = s_4.F5.F3;
            }
            else
            {
                if (s_4.F0)
                {
                    s_4.F5.F2 = 115;
                    byte var4 = s_5.F5.F1;
                    s_4 = s_5;
                    s_7 = s_7;
                }
                else
                {
                    s_1[0, 0] = s_5.F1;
                }

                s_8 = s_5.F5.F4;
            }

            s_8 = s_5.F5.F4;
        }

        return 4117296345U;
    }

    static sbyte M6(char arg0, ushort arg1, C0[] arg2, byte arg3, char arg4)
    {
        arg2[0].F5.F1 = 0;
        if (true)
        {
            if (false)
            {
                arg2[0].F5.F4 = 1;
                {
                    S0[] var0 = new S0[]{new S0(1U, 81, 255, 23940, 1), new S0(3783508929U, 2, 1, 58085, 0), new S0(10U, 129, 115, 1, -32767), new S0(155859244U, 1, 166, 38862, 10), new S0(0U, 1, 10, 47160, 1778), new S0(4294967294U, 170, 233, 18782, 1), new S0(1U, 0, 255, 472, -19136), new S0(4294967295U, 139, 230, 13558, -1)};
                }

                arg2[0] = new C0(true, -5753, 'M', 1, 559003698500474242UL, new S0(0U, 192, 255, 20549, 32767), 5841);
            }
            else
            {
                if (arg2[0].F0)
                {
                    arg2[0] = new C0(false, 1, 'X', 2, 18446744073709551614UL, new S0(3750827955U, 0, 255, 43554, -1), 14288);
                    arg2 = arg2;
                    arg0 = '<';
                    ulong var1 = arg2[0].F4;
                }

                s_1 = s_1;
            }

            arg2[0].F5.F2 = 91;
            uint var2 = arg2[0].F5.F0;
            {
                arg2[0].F3 = arg2[0].F3;
            }

            arg2[0].F0 = arg2[0].F0;
            if (false)
            {
                if (true)
                {
                    arg2[0].F5.F0 = var2--;
                    C0[] var3 = new C0[]{new C0(true, 31892, 'h', 1405626277, 14268663204729299585UL, new S0(337383150U, 85, 85, 1, -13127), 44021), new C0(true, 25599, '{', 1563385696, 1UL, new S0(4294967294U, 205, 73, 0, 5259), 2), new C0(false, -15016, '7', -1, 16522156479059283608UL, new S0(753453246U, 0, 250, 26827, 22590), 2), new C0(true, -32768, ':', 2147483646, 1UL, new S0(4294967295U, 11, 251, 61853, -32767), 1), new C0(true, -32493, 'A', -2147483647, 2288232759619408997UL, new S0(4294967294U, 255, 212, 63931, 29085), 1), new C0(true, 1, 'Q', -2, 18110596134312092216UL, new S0(847394524U, 1, 1, 38172, 14381), 10), new C0(false, -32767, 'x', 10, 0UL, new S0(3017414358U, 0, 255, 0, 3956), 1), new C0(true, 19001, '8', 82576233, 1UL, new S0(4294967294U, 46, 229, 0, -32768), 61545), new C0(true, 24555, '|', -10, 0UL, new S0(3983516263U, 242, 70, 3246, -32768), 54137), new C0(false, 10, '!', 2147483647, 13732348353630311068UL, new S0(0U, 1, 94, 65534, 0), 1)};
                    arg2[0].F5.F2 /= (byte)(1 | 1);
                    long var4 = 8312693225272521408L;
                    var3 = var3;
                    if (var3[0].F3 <= 2147483646)
                    {
                        if (arg2[0].F0)
                        {
                            arg2[0].F5.F1 = var3[0].F5.F2;
                            M7(var3[0].F5.F0);
                            sbyte var5 = -98;
                        }
                    }
                    else
                    {
                        if (var3[0].F0)
                        {
                            var3[0].F0 = arg2[0].F0;
                            var3[0] = arg2[0];
                        }
                        else
                        {
                            arg3 = var3[0].F5.F1;
                            M8();
                        }

                        arg2 = var3;
                    }

                    C0[, ][] var6 = new C0[, ][]{{new C0[]{new C0(true, 0, 'Q', 1801876493, 1UL, new S0(0U, 25, 73, 65535, 7187), 35990)}}, {new C0[]{new C0(true, 32766, 'V', 2, 18446744073709551614UL, new S0(3810039253U, 236, 1, 1, 28308), 15523)}}, {new C0[]{new C0(true, -5509, '(', 236752799, 1UL, new S0(3867365884U, 1, 241, 0, 1647), 51040)}}, {new C0[]{new C0(false, -32768, 'E', 2147483646, 18446744073709551615UL, new S0(0U, 112, 76, 33894, -32767), 65534)}}};
                    s_4.F5.F0 = s_4.F5.F0;
                    var6[0, 0][0].F5.F3 = var6[0, 0][0].F5.F3;
                    arg2[0].F1 = var6[0, 0][0].F1;
                    sbyte var7 = 113;
                }
                else
                {
                    bool var8 = arg2[0].F0;
                    uint var9 = 951860603U;
                    s_4.F5.F0 = arg2[0].F5.F0++;
                }
            }
            else
            {
                s_5.F4 = 1796943524201899893UL;
                arg2[0].F5.F3 = s_4.F6;
                if (arg2[0].F0)
                {
                    C0 var10 = new C0(false, -24419, 'W', 936529128, 0UL, new S0(4017348366U, 1, 154, 0, -32768), 10767);
                }
                else
                {
                    s_6 = s_6;
                }
            }

            s_5.F5.F3 = s_5.F5.F3;
            M13();
        }
        else
        {
            {
                M7(arg2[0].F5.F0--);
                ushort var11 = s_5.F5.F3;
                s_1[0, 0] = (short)(-541800509311959117L % (int)((int)M10() | 1));
            }
        }

        arg2[0].F5.F1 = (byte)M17(arg2[0].F3, s_3, M11(s_3), arg2[0].F5.F4, 8207684388518700841L, s_2);
        return 34;
    }

    static C0 M7(uint arg0)
    {
        S0 var0 = new S0(0U, 0, 255, 1, 1);
        var0.F4 = (short)(126 & (uint)(1639603396 % (ushort)((ushort)(var0.F3 * -128) | 1)));
        return new C0(false, 13032, 'B', 2011431056, 1UL, new S0(1U, 127, 168, 57076, -18891), 0);
    }

    static C0 M8()
    {
        s_1[0, 0] = s_1[0, 0];
        s_1 = s_1;
        return M9(126);
    }

    static C0 M9(sbyte arg0)
    {
        s_2 = s_2;
        if (false)
        {
            s_2 -= s_2;
            if (true)
            {
                s_2 = 4814991605360130369UL;
                s_1[0, 0] = s_1[0, 0];
                bool var0 = false;
                var0 = var0;
                {
                    s_1 = new short[, ]{{-32767, 32766}, {15282, 1}, {0, 29114}, {0, 22227}, {1, -2712}, {-25424, 32767}, {-6014, -32767}, {5800, -32767}, {10672, 24701}, {32766, 32767}};
                    short var1 = s_1[0, 0]++;
                }

                arg0 = arg0;
                s_1[0, 0] = s_1[0, 0];
            }

            arg0 = arg0;
        }

        if (false)
        {
            bool var2 = M10() == s_2;
            bool var3 = var2;
            if (var3)
            {
                s_1[0, 0] = (short)M14(11139);
                s_2 = s_2;
            }

            if (true)
            {
                arg0 = (sbyte)((ushort)M10() * 3261135949U);
                M15();
                arg0 = arg0;
            }
            else
            {
                S0 var4 = new S0(776771379U, 76, 139, 65535, -27483);
                arg0 = arg0;
                var4.F4 = -28837;
                var3 = var2;
            }

            if (var3)
            {
                var2 = true;
            }

            {
                s_1[0, 0] = s_1[0, 0];
                s_1[0, 0] = (short)M10();
                s_1[0, 0] = (short)M10();
                var2 = var2;
                s_1[0, 0] = s_1[0, 0]++;
                if (false)
                {
                    if (true)
                    {
                        var2 = var3;
                        s_1[0, 0] = s_1[0, 0];
                        arg0 = arg0;
                        s_2 <<= -1124284246;
                        var3 = var2;
                    }

                    C0 var5 = new C0(false, 1, 'r', 896387853, 1UL, new S0(3658316589U, 10, 2, 6220, 10546), 0);
                    M14((short)(var5.F3 + (short)M16(var5.F0)));
                }
            }

            {
                if (true == var2)
                {
                    s_1[0, 0] = s_1[0, 0];
                }

                if (true && true)
                {
                    var2 = var2;
                }
                else
                {
                    s_3 /= (sbyte)(s_3 | 1);
                }

                {
                    if (var2)
                    {
                        arg0 = -13;
                        int var6 = 1476783598;
                    }

                    if (false)
                    {
                        M11(M17((int)M14(s_1[0, 0]++), arg0, 2L, s_1[0, 0]++, (long)M14((short)M11(arg0)), s_2));
                        var2 = var2;
                        s_4 = s_4;
                        {
                            s_4 = s_4;
                            s_1[0, 0] *= (short)(-1459 + s_4.F5.F0);
                        }

                        ulong var7 = 6731307386247947878UL;
                        {
                            {
                                byte var8 = 34;
                                short var9 = -5595;
                                s_1 = new short[, ]{{1, -32767, -7789, 32767, -10}, {32767, -7079, 0, -4446, -20398}, {1, -11527, -10, 29482, 0}, {-31621, 32222, 32767, -2, -2}, {0, 24687, -17375, -30567, -3181}, {26030, -32768, 32767, 6568, 0}, {7519, 0, 1, -21263, -10499}, {-32767, 32766, 0, -32767, 3168}, {-32768, 905, 751, 1, -32767}, {17568, 0, -32767, 32006, 22745}};
                                uint var10 = (uint)((sbyte)M11(-67) % (uint)((uint)(s_4.F3 / (short)(M15() | 1)) | 1));
                                short var11 = 12036;
                            }
                        }

                        M12(var2, 52459, (ulong)M15(), var3, (short)M17(s_4.F3, s_3, -1588256751233956077L, (short)(s_4.F1++ / (short)(s_4.F1 | 1)), (long)M14(s_4.F5.F4), var7), -806906888909126912L);
                        var7 = s_2;
                    }
                    else
                    {
                        s_4.F3 = s_4.F3;
                        s_4.F5.F1 = (byte)(s_4.F3 % (long)((1L & (long)M15()) | 1));
                        var3 = var3;
                    }

                    s_5 = s_4;
                    var3 = s_4.F0;
                }

                if (s_1[0, 0] != s_5.F3)
                {
                    s_4.F5.F4 = -10301;
                    s_5.F5.F4 = (short)M14(17910);
                }
                else
                {
                    --s_5.F2;
                    s_1[0, 0] = s_1[0, 0];
                }

                s_5.F6 >>= -755781963;
            }

            if (var2)
            {
                var3 = var3;
                s_4.F3 = -1;
                s_5.F5.F2 = 255;
                {
                    return new C0(true, 32766, '9', -313541093, 14510791812365475469UL, new S0(0U, 1, 1, 64109, -32768), 8138);
                }

                if (var2)
                {
                    C1 var12 = M12(var2, 14518, s_4.F4, false, (short)M11(s_3), (long)(s_5.F5.F3 ^ s_5.F3--));
                    {
                        var12.F8 = (uint)M13();
                    }

                    var12.F4.F5.F1 = s_4.F5.F1++;
                    {
                        C0 var13 = new C0(false, -12069, '0', 1720051915, 18446744073709551614UL, new S0(3274685257U, 0, 203, 1, -5949), 1);
                    }

                    s_4.F5.F4 = s_4.F5.F4;
                }
            }
        }

        return s_5;
    }

    static char M10()
    {
        M11((sbyte)((byte)M11(-128) % (byte)(1 | 1)));
        return M14(s_1[0, 0]);
    }

    static long M11(sbyte arg0)
    {
        if (true)
        {
            arg0 = (sbyte)((ushort)(3138140681U * arg0) ^ 1);
            if (((3931610861U | arg0) == (short)(s_1[0, 0] & 0U)) && true)
            {
                s_1 = s_1;
                s_1[0, 0] = s_1[0, 0];
                if (true)
                {
                    if (true)
                    {
                        C1 var0 = M12(false, 26246, s_2, false, s_1[0, 0]--, (long)('=' | (ushort)((long)((ushort)(1 | s_1[0, 0]) | 0) + 9223372036854775806L)));
                        var0.F3.F1 %= (short)(-32440 | 1);
                    }
                    else
                    {
                        s_1[0, 0] = -28265;
                    }

                    if (false)
                    {
                        s_1 = s_1;
                    }
                }

                s_1 = new short[, ]{{-26606, -9856}, {-32767, -31031}, {1027, 95}, {1, 16428}, {16184, 10}, {2, 0}};
            }
            else
            {
                M12(s_1[0, 0]++ >= 'K', 1, s_2, false, M13(), 5340186296949291488L);
                s_1 = s_1;
                s_1[0, 0] = 1;
            }

            int[][] var1 = new int[][]{new int[]{0, -10}, new int[]{-2147483648, -1587702736}, new int[]{-541838348, -1692049338}, new int[]{-1208073904}, new int[]{1326752690}, new int[]{509048668}, new int[]{-2147483647}, new int[]{2147483646, -2147483648}};
        }

        return (long)(1 + (int)M13());
    }

    static C1 M12(bool arg0, ushort arg1, ulong arg2, bool arg3, short arg4, long arg5)
    {
        arg2 = arg2;
        return new C1(65535, 5883156797048095500L, 2052496812U, new C0(false, 0, 'z', 661505594, 1UL, new S0(0U, 10, 0, 7506, -13287), 1), new C0(false, -32768, 'f', -1747990166, 18446744073709551615UL, new S0(1661824024U, 3, 41, 18598, -10437), 0), 13626015325496821960UL, -32768, new C0(true, -16381, 'H', 1597086899, 0UL, new S0(4294967295U, 1, 255, 1, 1), 0), 2299986279U, 1L);
    }

    static short M13()
    {
        s_2 = s_2;
        return 0;
    }

    static char M14(short arg0)
    {
        s_2 = s_2;
        C0[] var0 = new C0[]{new C0(true, -24293, '"', 478858823, 7484365755663262284UL, new S0(0U, 120, 0, 20823, -17697), 65534), new C0(true, -1, '%', 1147842136, 2399258135492197756UL, new S0(2286072703U, 94, 124, 65535, 18446), 1), new C0(true, 10, 'i', 534458147, 18446744073709551614UL, new S0(0U, 254, 116, 17475, -6445), 10), new C0(false, 21762, ':', 2147483646, 8938303035708853982UL, new S0(2672029226U, 0, 170, 62277, -18521), 7388), new C0(true, -2, 'P', 1584571644, 0UL, new S0(1U, 0, 255, 65535, -6478), 0)};
        return var0[0].F2;
    }

    static short M15()
    {
        M16(238 <= (uint)M16(false));
        if (false)
        {
            char var0 = (char)((byte)(254 - (int)(0 + (uint)((long)M16(true) % (long)((long)(159 - (byte)((sbyte)M16(false) / (short)(s_1[0, 0] | 1))) | 1)))) - s_2);
            var0 = var0;
            s_1 = s_1;
            s_2 = 18446744073709551614UL;
        }

        sbyte var1 = -2;
        s_1[0, 0] %= (short)(s_1[0, 0] | 1);
        s_1[0, 0] = s_1[0, 0]++;
        return s_1[0, 0];
    }

    static ulong M16(bool arg0)
    {
        s_2 = s_2;
        s_1[0, 0] = -1;
        s_1 = new short[, ]{{32766, -32768, -19667, -19550, 19430, 0, -32767, 1, -32768}, {21821, 7429, 24176, 21965, -1526, 32767, -32768, 1, -32767}, {-14442, 4914, -32768, -32768, -2147, 32767, 0, -30734, 30498}, {-32767, -32768, 1, 32767, 7666, 2, -9821, -12878, 9001}};
        return s_2;
    }

    static sbyte M17(int arg0, sbyte arg1, long arg2, short arg3, long arg4, ulong arg5)
    {
        arg3 += -32768;
        return arg1;
    }

    static byte M18(int arg0, C0 arg1, C0[] arg2, C0 arg3, uint arg4)
    {
        s_4.F3 = s_4.F3;
        return arg2[0].F5.F2;
    }

    static int M19(long arg0, C0 arg1, C0 arg2, bool arg3, bool arg4, ushort[] arg5, char[] arg6)
    {
        if (arg4)
        {
            arg2.F2 = arg1.F2;
        }

        return -2;
    }

    static ushort[] M20()
    {
        if (s_4.F0)
        {
            s_2 >>= s_4.F3--;
            s_5.F5.F1 = s_5.F5.F2;
            s_4.F4 = s_5.F4;
            short[] var0 = new short[]{0, -32767, -21442, 5450, -32767, -10358, 32766, 1, 32766};
            s_4.F2 = s_4.F2++;
        }

        return new ushort[]{1};
    }

    static uint M21()
    {
        s_4.F5.F0 = s_5.F5.F0;
        uint var0 = 10U;
        return (uint)((long)(s_4.F5.F2 | 4294967294U) / (char)('%' | 1));
    }
}