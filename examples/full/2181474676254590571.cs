// Generated by Fuzzlyn on 2018-06-03 23:31:25
// Seed: 2181474676254590571
class C0
{
    public uint F0;
    public bool F1;
    public int F2;
    public byte F3;
    public C0(uint f0, bool f1, int f2, byte f3)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
        F3 = f3;
    }
}

public class Program
{
    static ulong[] s_1 = new ulong[]{1UL, 7146666222330730160UL, 0UL, 18446744073709551614UL};
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        long[][] var0 = M1(new int[]{550477655, 1, 1, -1690193847, -413783243});
    }

    static long[][] M1(int[] arg0)
    {
        if (false)
        {
            M2((uint)M2((uint)M2(4294967295U)));
        }

        {
            if (true)
            {
                arg0[0] = 10;
                s_1 = s_1;
                if (M4())
                {
                    M5();
                    if (M4())
                    {
                        arg0 = arg0;
                    }
                    else
                    {
                        if (M4())
                        {
                            {
                                arg0[0] = 1425858802;
                                M4();
                            }

                            arg0[0] = arg0[0];
                        }
                    }
                }
            }

            s_1 = s_1;
            arg0[0] = arg0[0];
            {
                arg0 = new int[]{2147483647, -1762053581};
                long var0 = (long)(1 ^ arg0[0]);
                s_1[0] = s_1[0];
                M4();
                if (false)
                {
                    bool var1 = true;
                }
                else
                {
                    arg0 = arg0;
                    if (true)
                    {
                        M5();
                    }
                    else
                    {
                        s_1 = new ulong[]{7680475526182725821UL, 12614735154393948362UL, 14320952519226793949UL, 10UL, 0UL, 0UL};
                    }
                }

                s_1[0] = s_1[0];
            }

            arg0[0] = arg0[0];
        }

        return new long[][]{new long[]{-7969652918494288720L}, new long[]{-2263062721760184704L}, new long[]{-2229663051798326134L}, new long[]{7764484447038120475L}, new long[]{9223372036854775807L}, new long[]{1L}};
    }

    static sbyte M2(uint arg0)
    {
        {
            M3();
        }

        return 99;
    }

    static bool[] M3()
    {
        s_1 = new ulong[]{1UL, 16698558307721607078UL, 8358217380954910995UL};
        return new bool[]{true, false, true, true, false, false, false, true, false};
    }

    static bool M4()
    {
        if (false)
        {
            M5();
        }
        else
        {
            s_1 = new ulong[]{3894941160965082211UL, 4848749493974334422UL, 0UL, 4584372095856578926UL};
            M5();
            if (true)
            {
                if (true)
                {
                    if (true)
                    {
                        s_1[0] ^= s_1[0];
                    }
                    else
                    {
                        M5();
                    }

                    s_1[0] -= s_1[0];
                    s_1 = new ulong[]{3467148605173143852UL, 1UL};
                    {
                        if (false)
                        {
                            s_1 = new ulong[]{1UL};
                        }
                        else
                        {
                            s_1 = s_1;
                        }
                    }
                }
            }

            s_1[0] = s_1[0];
        }

        return false;
    }

    static short M5()
    {
        if (true)
        {
            s_1 = s_1;
        }

        C0 var0 = new C0(1680250913U, true, -1632240759, 1);
        var0.F0 = (uint)(var0.F0 - (ulong)((short)(var0.F0 ^ 255) % (int)(var0.F2 | 1)));
        return 25585;
    }
}