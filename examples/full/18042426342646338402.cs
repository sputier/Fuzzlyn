// Generated by Fuzzlyn on 2018-06-03 23:26:17
// Seed: 18042426342646338402
struct S0
{
    public ulong F0;
    public ulong F1;
    public sbyte F2;
    public S0(ulong f0, ulong f1, sbyte f2)
    {
        F0 = f0;
        F1 = f1;
        F2 = f2;
    }
}

class C0
{
    public S0 F0;
    public C0(S0 f0)
    {
        F0 = f0;
    }
}

public class Program
{
    static int s_1 = 1;
    static sbyte s_2 = -63;
    static byte[] s_3 = new byte[]{46, 149, 0};
    static bool s_4 = true;
    static sbyte s_5 = 71;
    static sbyte[, ] s_6 = new sbyte[, ]{{10, 0, -86, -74, 0, 1, -102, 106, -36, 1}, {42, 126, 78, 1, -127, 44, -2, 0, -55, 56}, {37, 127, -71, 1, 0, 1, -127, 127, -127, 0}};
    static S0 s_7 = new S0(18446744073709551615UL, 17601509799322078754UL, 125);
    static S0[] s_8 = new S0[]{new S0(18446744073709551614UL, 1UL, 31), new S0(8037383441091921811UL, 3533290487089535983UL, 32), new S0(1UL, 11091058161949256845UL, 2), new S0(15761282730977325043UL, 2UL, 126), new S0(1UL, 6005139210928207916UL, -73)};
    static short s_9 = -6224;
    static byte[] s_10 = new byte[]{0, 18, 1, 2, 0, 90, 1, 182, 10, 1};
    static ulong s_11 = 52271579310926821UL;
    static uint s_12 = 1U;
    static C0 s_13 = new C0(new S0(17967881637779635896UL, 12358365685304689711UL, -127));
    static int s_14 = 1;
    static long s_15 = 9223372036854775807L;
    static byte s_16 = 0;
    static short s_17 = 25055;
    static short s_18 = 9546;
    static int s_19 = 803727563;
    static char s_20 = '[';
    static long[] s_21 = new long[]{-9223372036854775807L, 6514259061531874350L};
    static ulong s_22 = 1UL;
    public static void Main()
    {
        M0();
    }

    static void M0()
    {
        M1(new ushort[]{65534});
        s_7.F1 = (ulong)M17(s_1);
        if (M21(false))
        {
            s_8[0] = new S0(14804666746964194214UL, 1UL, 19);
        }

        M4(new S0(2UL, 0UL, -10));
        {
            s_4 = s_4;
            if (s_4)
            {
                S0 var0 = s_8[0];
            }
        }

        ushort var1 = 25965;
        s_13 = new C0(s_13.F0);
        M13(new uint[]{155984466U, 4294967295U, 2195640010U, 2669158605U}, new sbyte[]{92, 2, 126, 1, 1, 0});
        s_8[0] = s_8[0];
        s_3[0] = s_3[0];
        if (s_4)
        {
            {
                {
                    {
                        {
                            s_10[0] = s_16++;
                            s_7.F2 = s_2;
                            bool var2 = 828968108762803857L == s_15;
                            s_15 = s_15;
                        }

                        if (true)
                        {
                            short var3 = s_9--;
                            int var4 = 10;
                        }
                        else
                        {
                            s_13.F0.F2 = s_7.F2;
                            {
                                C0 var5 = s_13;
                                int var6 = s_14--;
                                S0[] var7 = s_8;
                            }
                        }
                    }

                    s_19 = s_14;
                }
            }
        }
        else
        {
            {
                s_13.F0.F1 = 5120270201118334721UL;
                {
                    s_1 = -1103962326;
                    var1 = var1;
                    int var8 = s_19;
                    C0 var9 = s_13;
                    s_6 = s_6;
                    s_20 = s_20;
                    s_21 = s_21;
                    if (true)
                    {
                        s_10 = new byte[]{0, 1};
                        s_22 = s_22;
                    }
                }

                s_13.F0.F1 = s_13.F0.F1;
                s_6 = new sbyte[, ]{{107, -128, 53}, {-93, 40, 27}, {126, 102, 61}};
                long var10 = (long)M20();
            }
        }

        if (s_4)
        {
            uint var11 = 1729132199U;
            s_7.F1 <<= (int)M18();
        }

        {
            s_19 = s_19++;
            uint var12 = (uint)(64 ^ s_20);
            s_5 = s_5;
            s_18 = (short)M20();
        }

        s_8[0].F0--;
        short var13 = s_9;
        s_13 = s_13;
        s_7.F2 = s_2++;
    }

    static uint M1(ushort[] arg0)
    {
        if (false)
        {
            M2(new ulong[]{0UL, 15819413868223011318UL, 12585846027562012114UL, 1985590751089643827UL});
        }
        else
        {
            if (true)
            {
                int var0 = (int)((short)(2069317963U % (uint)((uint)(-98936052 | (byte)((long)(arg0[0] % (uint)(0U | 1)) ^ (short)(-20 & M3()))) | 1)) & s_12);
            }

            s_8 = new S0[]{new S0(1UL, 1UL, -128), new S0(12548458701497074038UL, 0UL, 1), new S0(0UL, 16561964287141881998UL, 1), new S0(0UL, 2775708652295912651UL, -128)};
        }

        return s_12;
    }

    static C0 M2(ulong[] arg0)
    {
        ulong[, ] var0 = new ulong[, ]{{10UL, 2256343472528269052UL, 1UL, 1UL, 2619336130852646209UL, 6642538806765220746UL}, {13791869410384275819UL, 18446744073709551614UL, 0UL, 18446744073709551615UL, 9345353015228687415UL, 11558954940338574415UL}, {10UL, 12842726688899250355UL, 17282300299346965288UL, 11713420915787577265UL, 6003886676319080195UL, 8266822231318660833UL}, {1UL, 18446744073709551615UL, 10UL, 1UL, 1UL, 18446744073709551615UL}, {634977016153099815UL, 0UL, 5797713495859467373UL, 1UL, 7845000774841203109UL, 8564202466344114393UL}, {1UL, 0UL, 1UL, 12358829293812076598UL, 660606820402018575UL, 2UL}, {653919934809463629UL, 17046536779497702524UL, 0UL, 11052865367631790185UL, 2UL, 0UL}, {1639499197775201191UL, 0UL, 0UL, 11233875196862926474UL, 17687630059207611477UL, 15085129983761348204UL}};
        return new C0(new S0(0UL, 1UL, 1));
    }

    static uint M3()
    {
        if (true)
        {
            ushort[] var0 = new ushort[]{0, 65534};
            var0[0] = var0[0];
        }

        if (false)
        {
            char var1 = 'q';
        }
        else
        {
            {
                s_1 = s_1;
                {
                    s_1 = s_1;
                }

                if (false)
                {
                    C0 var2 = new C0(new S0(18446744073709551615UL, 11878655607756831915UL, 5));
                    s_2 = 126;
                }
                else
                {
                    S0 var3 = new S0(0UL, 0UL, 9);
                }
            }

            if (false)
            {
                ulong[, ] var4 = new ulong[, ]{{7555153552547219091UL, 18382951101282198810UL, 9134439457864455599UL, 18446744073709551615UL, 7767835074176865340UL}, {15601903707755457149UL, 7504038562926460372UL, 4978565178133891507UL, 13326919250931302471UL, 0UL}, {0UL, 1UL, 3301989382178337306UL, 1UL, 6819481369594949483UL}, {13178797539973073614UL, 18446744073709551614UL, 16677352953570080115UL, 2598626124629268626UL, 484034937461825307UL}, {14223413338293195829UL, 0UL, 8513056238465859178UL, 15467418123766484533UL, 851448412179810078UL}, {13450505455890358496UL, 1UL, 17334703580118427808UL, 4791009211176222091UL, 0UL}, {13437427417547357893UL, 10UL, 6830921452937811797UL, 1205101018629173195UL, 13559431365438604873UL}, {0UL, 2UL, 1UL, 8421939542043414887UL, 3443397108747336465UL}, {18446744073709551614UL, 10794299633441017068UL, 5997679968120387760UL, 14482894381929197470UL, 18446744073709551614UL}, {11917680804111421680UL, 1628232909631970079UL, 15588279942051431097UL, 14050654074775242429UL, 0UL}};
                s_1 = s_1--;
            }
            else
            {
                {
                    M4(new S0(5873003711196003853UL, 1664958489539133315UL, 1));
                    s_1 = (int)M4(new S0(0UL, 4018369072865473149UL, -52));
                }
            }
        }

        char var5 = (char)((sbyte)M4(new S0(9935265896961789134UL, 16990011754901462411UL, 127)) - s_2);
        s_2 = s_2++;
        s_2 %= (sbyte)(s_2 | 1);
        if (false)
        {
            var5 = var5;
        }
        else
        {
            var5 = var5++;
        }

        {
            s_1 = (int)M4(new S0(18446744073709551615UL, 14643196005345074146UL, -3));
            s_2 = s_2--;
        }

        if (false)
        {
            s_1 = -1340802578;
            if (true)
            {
                s_2 = s_2;
                uint var6 = 0U;
                ulong var7 = (ulong)M4(new S0(18446744073709551615UL, 18446744073709551615UL, -52));
                bool var8 = true;
                if (true)
                {
                    M5((long)(-128 | (sbyte)M6((byte)M6((byte)(var5 * s_1), -850380150, new ushort[]{65535, 8566, 65535, 55843, 63212}), s_1, new ushort[]{23126, 2909, 0, 1, 17544, 1, 23094, 41203})), (short)M6(1, s_1, new ushort[]{1, 6494, 1, 61317}), new byte[][]{new byte[]{207, 216}, new byte[]{122, 1}, new byte[]{254}, new byte[]{1, 116}, new byte[]{1, 0}, new byte[]{254, 126}});
                }
                else
                {
                    {
                        var6 = 0U;
                        var5 = var5++;
                        var6 = var6;
                    }

                    s_1 = 2147483646;
                    var6 /= (uint)(var6 | 1);
                }

                s_1 = s_1;
                var6 = var6;
                var6 = var6;
                if (var8)
                {
                    var8 = var8;
                    var8 = true;
                    M5(1L, 683, new byte[][]{new byte[]{152, 1, 70, 74, 163}, new byte[]{254, 0, 182, 254, 162, 6}, new byte[]{254, 1, 92}, new byte[]{96, 0, 0}, new byte[]{229, 0, 97, 242, 53, 0}, new byte[]{51, 241, 0, 218, 36, 0}, new byte[]{10, 0, 218}, new byte[]{108, 255, 65, 178, 1, 1}, new byte[]{21, 0, 209, 240}});
                }
                else
                {
                    M7(new char[]{'"', '`', 'h'}, (sbyte)(0 / (byte)(s_10[0] | 1)));
                }

                s_8[0] = s_13.F0;
                s_15 = -2L;
                s_13.F0.F0 = M22(1, 1832501036);
                if (s_4)
                {
                    ushort[] var9 = new ushort[]{0};
                    {
                        C0 var10 = s_13;
                    }
                }
                else
                {
                    {
                        S0 var11 = s_13.F0;
                        {
                            s_16 = 0;
                            ushort var12 = 2888;
                        }
                    }

                    var5 = var5;
                }

                if (s_4)
                {
                    if (var8)
                    {
                        s_8[0].F0 = s_7.F0;
                        if ((ulong)(s_6[0, 0]++ % (sbyte)(s_6[0, 0]++ | 1)) != s_3[0])
                        {
                            s_8[0] = s_13.F0;
                            s_3 = s_10;
                            s_9 = s_9;
                            var7 = 0UL;
                        }
                        else
                        {
                            s_16 = s_3[0];
                        }
                    }

                    s_7 = s_7;
                    s_8 = s_8;
                    var5 = var5;
                    s_13 = s_13;
                    s_17 = s_17;
                    s_12 = var6;
                    s_14 = (int)M24();
                    s_17 = (short)M13(new uint[]{0U, 809841720U, 582695604U}, new sbyte[]{-2});
                }
            }
        }

        s_18 = s_9;
        return s_12;
    }

    static char M4(S0 arg0)
    {
        s_2 = 126;
        return '!';
    }

    static C0 M5(long arg0, short arg1, byte[][] arg2)
    {
        long var0 = arg0;
        {
            M6((byte)M6((byte)((long)M6(214, s_1--, new ushort[]{8360, 0, 65535, 0, 16534, 0, 52230, 1, 46204, 0}) + s_1), s_1, new ushort[]{44332, 62069, 65535, 60313, 26623}), 425362476, new ushort[]{20195, 26835, 43344, 50665, 65534});
            arg2 = arg2;
            arg0 = var0;
            return new C0(new S0(0UL, 7093364258689874972UL, 69));
        }

        return new C0(new S0(13085571006171359130UL, 12075672763761062522UL, -10));
    }

    static ushort M6(byte arg0, int arg1, ushort[] arg2)
    {
        ulong var0 = 1UL;
        ulong var1 = 0UL;
        return arg2[0];
    }

    static uint[] M7(char[] arg0, sbyte arg1)
    {
        arg0 = arg0;
        if (true || true)
        {
            long var0 = (long)(-92 * s_2);
            var0 = 0L;
            if (false)
            {
                var0 += var0;
                arg1 = arg1--;
            }
        }
        else
        {
            s_2 = 126;
            {
                M8('r');
                s_1 = 0;
                if (false)
                {
                    s_2 = arg1;
                    s_3 = s_3;
                    if (true)
                    {
                        s_3 = s_3;
                    }
                    else
                    {
                        if (true)
                        {
                            arg1 = arg1++;
                            s_3 = s_3;
                            M8((char)(-9223372036854775807L & (ushort)(s_1 ^ s_3[0])));
                            uint var1 = 2U;
                            if (false)
                            {
                                s_4 |= s_4;
                                var1 = 4294967295U;
                                arg0 = arg0;
                            }
                            else
                            {
                                s_2 += arg1;
                                long var2 = 1L;
                                M8(arg0[0]);
                                s_3 = s_3;
                                s_2 = arg1--;
                            }

                            s_3 = s_3;
                            {
                                ++s_1;
                                M8(arg0[0]);
                                if (s_1 < var1)
                                {
                                    arg1 *= arg1;
                                    arg0 = arg0;
                                    s_4 = s_4;
                                    ulong var3 = 1UL;
                                    M8(arg0[0]);
                                    var3 = var3;
                                }
                                else
                                {
                                    var1 = 3732012713U;
                                }
                            }
                        }
                        else
                        {
                            s_3[0] = s_3[0];
                        }
                    }
                }
                else
                {
                    if (s_4)
                    {
                        if (true)
                        {
                            if (s_4)
                            {
                                s_5 = (sbyte)(1825801278U & arg0[0]);
                                s_1 = s_1++;
                                bool var4 = s_4;
                            }
                            else
                            {
                                M8('4');
                                ushort var5 = 1;
                                uint var6 = 1725632056U;
                                s_3[0] = 0;
                                s_1 = s_1++;
                            }

                            {
                                s_6 = s_6;
                                if (s_4)
                                {
                                    s_7 = new S0(0UL, 12910629981228334159UL, 1);
                                }
                            }

                            s_7.F2 = s_5;
                        }
                        else
                        {
                            if (s_1 > (ushort)(-31998 / (long)((long)(s_3[0] + arg0[0]) | 1)))
                            {
                                M8(arg0[0]);
                                s_4 = s_4 || s_4;
                            }
                            else
                            {
                                s_5 = (sbyte)(254 & M9(new ulong[, ]{{7279248453875906903UL, 17519840243138697217UL, 16807790508345576863UL, 17335793531991295472UL, 8773920928087008672UL, 8034510464261061765UL, 0UL, 11262122778233245371UL, 12227348022756549997UL}}));
                                s_3 = s_3;
                                s_6[0, 0] = M13(new uint[]{4209815622U, 4132528033U, 725347886U, 3069443877U, 723261675U, 1U}, new sbyte[]{-1, 79, 1});
                                s_6[0, 0] = M11();
                            }
                        }
                    }

                    if (s_4)
                    {
                        M16(0L, s_1, s_7.F2, 20016);
                    }

                    if (s_4)
                    {
                        s_13 = M14();
                    }
                    else
                    {
                        s_6[0, 0] = s_7.F2--;
                    }

                    char var7 = (char)M9(new ulong[, ]{{1UL}, {18446744073709551615UL}, {9131391442677548543UL}, {5032380654496762643UL}, {15397794624713423786UL}, {18446744073709551615UL}, {1UL}});
                }
            }

            s_10[0] = (byte)M18();
            if (s_4)
            {
                M14();
                s_10 = new byte[]{13, 254, 26, 235};
                {
                    s_7.F2 = s_2;
                }
            }

            if (s_4)
            {
                M17((int)M19(2731, new ulong[, ]{{1UL, 9793092964854181227UL, 18446744073709551615UL, 18446744073709551615UL, 0UL, 0UL, 0UL, 6068300519024252242UL}, {1UL, 4215746344328900896UL, 838744327548451659UL, 1UL, 8283850201625757527UL, 15414011461754103098UL, 0UL, 8042366483467810286UL}, {1UL, 5586007247542032904UL, 18110895021172728236UL, 10UL, 18446744073709551614UL, 0UL, 1UL, 18446744073709551615UL}}));
            }
            else
            {
                ulong var8 = 228052004448123682UL;
                ushort var9 = 26243;
                s_3[0] = s_10[0];
            }

            s_7.F2 = s_13.F0.F2--;
            int var10 = 733817459;
            if (s_4)
            {
                {
                    ushort var11 = 2;
                    M8((char)(M24() % (sbyte)(10 | 1)));
                }
            }

            s_3 = s_10;
            if (true)
            {
                C0 var12 = s_13;
                {
                    s_14 = var10;
                    M12();
                }
            }
        }

        s_8[0].F0 -= (ulong)M24();
        return new uint[]{908237U, 1289459950U, 4294967294U, 4294967295U};
    }

    static C0 M8(char arg0)
    {
        s_1 = (int)(3926996158913213931UL / (char)(arg0 | 1));
        return new C0(new S0(1UL, 10UL, 127));
    }

    static sbyte M9(ulong[, ] arg0)
    {
        M10(3415798068606582978L, 18209196478465788750UL, (ushort)M19(30948, arg0));
        return s_2;
    }

    static byte M10(long arg0, ulong arg1, ushort arg2)
    {
        {
            s_7.F2++;
            M11();
        }

        s_8[0].F1 = (ulong)M19((ushort)M22(0, s_1), new ulong[, ]{{16777852883806731512UL, 2247960289677401132UL, 2UL, 13447610718453061748UL, 0UL, 7994479811185208526UL}, {1UL, 545161700950821972UL, 0UL, 7391080799278695418UL, 0UL, 18446744073709551614UL}, {0UL, 0UL, 18446744073709551614UL, 0UL, 7968631506763654617UL, 2633620323123225325UL}, {10UL, 17077173014472912490UL, 1UL, 1904412515409127233UL, 0UL, 1398028317317884413UL}, {1UL, 1UL, 1UL, 0UL, 16533141569660876582UL, 1UL}, {7877011462104014593UL, 0UL, 1UL, 10UL, 12481829080466118043UL, 9271200921630010852UL}, {13139540855080419621UL, 1UL, 17571850840357061492UL, 17679156683928589189UL, 6852799109069558171UL, 0UL}});
        return 2;
    }

    static sbyte M11()
    {
        if (s_4)
        {
            sbyte var0 = s_2;
            if (s_4)
            {
                s_3[0] = (byte)(-5894430611693950307L % (char)(M12() | 1));
                s_4 &= false;
                {
                    if (s_4)
                    {
                        {
                            s_4 = true;
                        }

                        {
                            M12();
                            s_5 = s_2;
                            short var1 = (short)((short)M12() - '<');
                            {
                                s_2 = var0;
                            }

                            s_3[0] = s_3[0];
                            s_5 = -115;
                            s_6 = s_6;
                            s_6 = s_6;
                            if (s_4)
                            {
                                s_4 = s_4;
                            }

                            s_3[0] = (byte)M12();
                        }
                    }
                    else
                    {
                        s_3[0] = 51;
                        M12();
                        var0 = s_6[0, 0]++;
                        s_8 = new S0[]{new S0(0UL, 12605635705874296124UL, 0), new S0(18446744073709551614UL, 13736155994376699854UL, -100), new S0(0UL, 2UL, 46), new S0(13834778162570798898UL, 13658053606429109310UL, 1), new S0(0UL, 0UL, -128), new S0(18446744073709551614UL, 6650257385307768442UL, -95), new S0(9905511901651484391UL, 18446744073709551615UL, 1)};
                        s_5 = (sbyte)((long)M12() & -32767);
                    }

                    if (false)
                    {
                        if (s_4)
                        {
                            s_7 = new S0(11951804684877529468UL, 18446744073709551615UL, 0);
                            s_2 = M13(new uint[]{4294967295U, 0U, 4294967294U, 3507780624U, 4294967295U}, new sbyte[]{0, 0, -10, -85, -98, -103, 0});
                            s_2 = -127;
                            var0 = (sbyte)('l' % (char)(M17((int)M13(new uint[]{1U, 0U}, new sbyte[]{10, 0, -127, 1})) | 1));
                        }
                        else
                        {
                            M15();
                            {
                                s_5 = var0;
                                s_9 = s_9;
                                M19(0, new ulong[, ]{{17656321121656958127UL, 0UL, 1UL, 18446744073709551615UL, 12415018406117401797UL}, {1UL, 12708857624722331251UL, 18446744073709551614UL, 3597818806250442508UL, 16475283350548882591UL}, {10UL, 10UL, 18446744073709551614UL, 18446744073709551615UL, 1UL}, {18446744073709551615UL, 18446744073709551615UL, 104303810114558550UL, 8857480516630800985UL, 18446744073709551615UL}, {1UL, 6539561653965625218UL, 1UL, 1UL, 15120600896107853189UL}, {16969831713522293004UL, 0UL, 15268926759999666046UL, 4632873503787698330UL, 0UL}, {5711523715242134956UL, 1UL, 0UL, 6572779513398318857UL, 0UL}, {0UL, 14696427371713393457UL, 0UL, 6079467823053048829UL, 946445667902882594UL}, {1UL, 0UL, 0UL, 4391803640010553515UL, 7763315511123293246UL}});
                                s_8[0].F0 = 18446744073709551615UL;
                                return (sbyte)(s_6[0, 0] + 9277);
                            }
                        }

                        s_10 = s_10;
                        s_10 = s_3;
                        s_6[0, 0] = (sbyte)M18();
                        s_1 = -2;
                    }
                }

                s_9 = s_9++;
                C0 var2 = M14();
                var0 = (sbyte)M18();
                s_6 = s_6;
                {
                    M13(new uint[]{785152616U, 3570690255U, 4294967294U, 0U, 191204414U}, new sbyte[]{2, -51, -127, -31, 127, 112});
                    long var3 = 9223372036854775807L;
                }
            }
            else
            {
                if (true)
                {
                    ushort var4 = (ushort)M13(new uint[]{1U}, new sbyte[]{8, -128, -18, -30, -28, -85, -127, -128});
                    s_8 = s_8;
                    M14();
                    s_1 = s_1;
                    M19(var4, new ulong[, ]{{1UL, 4314769756961756739UL, 1UL, 11453624930392217920UL, 654627679095374217UL, 18446744073709551615UL, 4104189831208373361UL, 1UL, 6541198708127116156UL, 1UL}, {11370353011876835088UL, 0UL, 1UL, 5255674287208574834UL, 5337680739757474022UL, 18446744073709551615UL, 18446744073709551615UL, 16198856216601048275UL, 16457075363968740823UL, 1UL}, {1609008671957175063UL, 15980901133527696168UL, 0UL, 0UL, 1UL, 0UL, 1UL, 1UL, 1UL, 2UL}, {6950016009860265028UL, 16871323975106065799UL, 0UL, 10324741715928443074UL, 6645947931541489599UL, 0UL, 18446744073709551615UL, 5285140832029819431UL, 4288347098050511849UL, 18446744073709551614UL}, {3127888459533502701UL, 1UL, 9483295661205967029UL, 2UL, 18446744073709551615UL, 11041391344087214633UL, 15923080120141991861UL, 0UL, 2727178520410771599UL, 8959827503905818612UL}, {1UL, 18446744073709551615UL, 2UL, 12946117164581445723UL, 1333286123288849099UL, 0UL, 17790315600859263761UL, 9006843967991630284UL, 7701992534543073654UL, 6803181831386486710UL}, {18446744073709551614UL, 0UL, 13310403838148185505UL, 1UL, 0UL, 1UL, 1354972973285943769UL, 1UL, 18446744073709551614UL, 0UL}, {1UL, 18446744073709551614UL, 17880591632216705210UL, 1UL, 6863751020823792517UL, 3704230937607154327UL, 18446744073709551615UL, 17479411919434463022UL, 12313941210173222226UL, 17873604653236381385UL}, {0UL, 411234540907195501UL, 10812849430593032830UL, 10296788543621860192UL, 9190997202455799135UL, 4639387636602655597UL, 0UL, 16385122626016326489UL, 16034551460302031243UL, 9870747758346655580UL}, {10UL, 7084238258763101972UL, 9745211699941339339UL, 14080519766600135255UL, 17279304456615237165UL, 15651842518807513944UL, 1UL, 10668591642954278272UL, 6790765787713080231UL, 7150929658708066177UL}});
                }
                else
                {
                    s_7.F2 = s_5;
                    byte var5 = 52;
                    if (s_4)
                    {
                        var5 = s_3[0];
                        s_9 ^= (short)M17((int)M12());
                        s_3 = s_3;
                        M12();
                        M17(s_1++);
                        s_3 = new byte[]{218, 133, 0, 1, 24};
                    }

                    char[] var6 = M15();
                    if (s_4)
                    {
                        ushort var7 = 40248;
                    }
                    else
                    {
                        s_8 = s_8;
                        s_8 = s_8;
                        byte var8 = s_3[0];
                    }

                    s_6 = s_6;
                    s_5 = M13(new uint[]{1U, 4294967295U, 4294967295U, 4294967294U, 1545348265U, 1U, 0U, 853045808U, 0U}, new sbyte[]{-128, -10, 7, 62, 0, -56});
                }
            }
        }

        if (true)
        {
            s_8[0] = s_8[0];
        }

        s_7.F2 = s_6[0, 0];
        if (M21(s_4))
        {
            s_4 = s_4;
        }
        else
        {
            if (s_4 ^ s_4)
            {
                char var9 = 'N';
                sbyte var10 = -46;
                M13(new uint[]{3968207954U, 501815216U, 1838590199U, 4294967295U}, new sbyte[]{-45, -127, 0, 70, -108, -128, 53, 121, 54, -84});
            }
            else
            {
                s_6 = s_6;
                s_11 = s_8[0].F1;
                if (false)
                {
                    if (s_4)
                    {
                        if (s_4)
                        {
                            s_8 = new S0[]{new S0(7026739457033820498UL, 361349106351206331UL, 63), new S0(18446744073709551615UL, 18446744073709551614UL, -128), new S0(1UL, 7840406993204051571UL, 1), new S0(8333274026879073448UL, 9860033277818431006UL, -20), new S0(0UL, 0UL, 119), new S0(1UL, 10602636838164475241UL, -82), new S0(0UL, 2647257875663622185UL, 126), new S0(0UL, 5020463159804002295UL, 31), new S0(578889033357364732UL, 1UL, -37), new S0(343772606004663963UL, 3843136735431899251UL, 10)};
                        }
                    }
                    else
                    {
                        if (false)
                        {
                            if (s_4)
                            {
                                M17(-1279125596);
                                s_1 >>= s_1;
                            }
                            else
                            {
                                s_8 = s_8;
                                long var11 = (long)M18();
                                short var12 = s_9;
                                s_8 = s_8;
                            }

                            char var13 = 'W';
                            if (M21(M21(false)))
                            {
                                S0[] var14 = s_8;
                            }
                            else
                            {
                                s_12 = s_12;
                            }
                        }
                        else
                        {
                            s_10 = s_3;
                        }
                    }

                    M23(10UL);
                }

                s_8[0].F2 = s_5;
                sbyte var15 = 0;
                s_7.F1 = (ulong)(21094 / (short)(s_9 | 1));
                s_7.F2 = s_2;
                if (false)
                {
                    s_6 = s_6;
                    M16((long)M12(), s_1, var15, 42831);
                    s_3 = new byte[]{10, 255, 57, 178, 0, 255, 254, 22, 164};
                    C0 var16 = M14();
                }

                s_8[0].F0 = (ulong)((ushort)M22(s_1--, -10) + s_12);
            }

            s_12 = s_12++;
            s_7.F1 = s_11;
            s_2 = s_2;
            s_8 = s_8;
            s_7 = new S0(18446744073709551615UL, 12540535394320213900UL, 112);
            sbyte var17 = s_7.F2;
            s_5 = -127;
            s_7.F1 *= s_7.F0;
            s_7.F0 = s_7.F0;
            ushort var18 = 7168;
        }

        return (sbyte)M17((int)M12());
    }

    static char M12()
    {
        s_2 = (sbyte)(s_1 * 'c');
        s_2 = s_5;
        s_6[0, 0] += s_7.F2;
        if (false)
        {
            s_6 = s_6;
        }

        return '(';
    }

    static sbyte M13(uint[] arg0, sbyte[] arg1)
    {
        if (s_4)
        {
            s_8[0] = new S0(18446744073709551615UL, 8749992392802013600UL, 0);
        }
        else
        {
            {
                s_5 = s_7.F2;
                sbyte var0 = 117;
                s_3 = s_3;
                {
                    s_9 = s_9;
                    ulong var1 = s_8[0].F0;
                    if (s_3[0] < 53015)
                    {
                        var0 = s_2;
                        bool var2 = s_4;
                        if (s_4)
                        {
                            s_8 = new S0[]{new S0(10493377455188165491UL, 0UL, -101), new S0(2641046939969400933UL, 0UL, 125), new S0(15862753405537536280UL, 9956233528802809582UL, 34), new S0(16064254597357076070UL, 8719358712653084378UL, -48), new S0(1796651832835111501UL, 1UL, -110), new S0(9648422531059392057UL, 0UL, 127)};
                            var1 = 0UL;
                            s_7.F2 = s_8[0].F2++;
                        }
                        else
                        {
                            s_7 = s_8[0];
                            s_7.F1 = s_7.F1;
                        }

                        M14();
                        s_5 = -105;
                        s_4 = false;
                        ushort[] var3 = new ushort[]{17226, 42946, 57010, 39804};
                    }
                    else
                    {
                        M14();
                        M15();
                    }
                }

                C0[] var4 = new C0[]{new C0(new S0(11057337734046423501UL, 13131790973134345975UL, 103)), new C0(new S0(10289950032093035993UL, 16329162180754635704UL, -47)), new C0(new S0(5794484325468075445UL, 17768549780792167917UL, -64)), new C0(new S0(18446744073709551614UL, 17843429271394296792UL, -2)), new C0(new S0(4090963717974160593UL, 13197621162713366028UL, 1)), new C0(new S0(11704799617853713860UL, 0UL, 1)), new C0(new S0(18285583893319801561UL, 12753852145927969380UL, 0)), new C0(new S0(3197767641708160966UL, 8435508432677793734UL, 0))};
                s_8[0].F2 = s_6[0, 0];
            }

            s_9 = s_9;
            s_7.F2 = 3;
            s_8 = new S0[]{new S0(18446744073709551615UL, 18446744073709551615UL, 0), new S0(1UL, 16299259153691807137UL, -1)};
            s_2 = s_8[0].F2;
            M16(-9223372036854775807L, s_1, s_5, 2);
        }

        return arg1[0];
    }

    static C0 M14()
    {
        s_7 = s_7;
        s_4 = s_4;
        byte var0 = 125;
        s_3 = s_3;
        s_8 = s_8;
        M15();
        return new C0(new S0(7358551164866472806UL, 0UL, 127));
    }

    static char[] M15()
    {
        s_7.F0 = 0UL;
        s_3 = s_3;
        uint[] var0 = new uint[]{4105312135U, 569486932U, 0U};
        return new char[]{'N', 'j', 'K', 'H', '5'};
    }

    static short[] M16(long arg0, int arg1, sbyte arg2, ushort arg3)
    {
        int var0 = arg1;
        return new short[]{17001, 1826, 22601, 32766, 32766, 1, 11160, -3676, -32767, -28037};
    }

    static char M17(int arg0)
    {
        M18();
        s_1 = arg0--;
        return 'I';
    }

    static char M18()
    {
        M19(65535, new ulong[, ]{{0UL, 18446744073709551615UL, 3162250706039436303UL, 1UL, 0UL, 13148410456910205500UL, 1UL, 13549353249430579666UL, 1UL, 4555934049305883645UL}, {14549247050220467719UL, 13881959313196173705UL, 1125130285870050508UL, 0UL, 1UL, 15274143600131413047UL, 1UL, 0UL, 3867437978788225364UL, 2396198617068577310UL}, {2099656662267225758UL, 0UL, 10981073454420275675UL, 18446744073709551614UL, 2UL, 0UL, 18446744073709551615UL, 8788381429613718188UL, 6956414794448273456UL, 0UL}});
        long var0 = (long)(1908031008U - (uint)M19(51063, new ulong[, ]{{1UL, 0UL, 4238749010043154032UL, 0UL}}));
        return M20();
    }

    static char M19(ushort arg0, ulong[, ] arg1)
    {
        s_7.F1 = s_8[0].F0;
        ulong var0 = arg1[0, 0];
        ushort var1 = arg0;
        return (char)(0U | s_9);
    }

    static char M20()
    {
        s_8[0].F0++;
        s_8[0].F2 = s_5;
        return '(';
    }

    static bool M21(bool arg0)
    {
        long var0 = 1212884640288391471L;
        s_5 = 1;
        s_1 = -1149876651;
        M22((int)M22(s_1, 10), 1);
        if (false)
        {
            M22(s_1, s_1++);
        }
        else
        {
            s_9 = s_9;
        }

        return arg0;
    }

    static ulong M22(int arg0, int arg1)
    {
        bool var0 = false;
        return s_8[0].F1;
    }

    static long[] M23(ulong arg0)
    {
        s_6 = s_6;
        return new long[]{9223372036854775806L, -8480780878680919847L, 9223372036854775806L, -7330100433427133761L, -6361517939580504527L, 6203912771127343795L, 0L, -2100528018121396833L, -9223372036854775807L, 898400713784077288L};
    }

    static long M24()
    {
        s_7 = s_13.F0;
        s_6[0, 0] = s_2;
        return 7159064829176678816L;
    }
}