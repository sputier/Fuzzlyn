// Generated by Fuzzlyn on 2018-06-03 23:13:53
// Seed: 16899603832773100027
// Reduced from 21.1 KB to 0.3 KB
// Debug: Outputs 2
// Release: Outputs 164
public class Program
{
    static short[] s_8 = new short[]{1};
    public static void Main()
    {
        s_8 = new short[]{-26465};
        int vr20 = 2;
        byte vr18 = (byte)((char)((uint)vr20 | s_8[0]) / 'L');
        System.Console.WriteLine(vr18);
    }
}
