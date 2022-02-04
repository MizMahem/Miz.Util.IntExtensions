namespace Miz.Util.IntExtensions;

public static partial class IntExtensions
{
    public static int DigitsLengthLog10(this int number) =>
        number == 0 ? 1 : (int)Math.Log10(Math.Abs(number)) + 1;

    public static int DigitsLengthWhile(this int number) {
        int digits = 1;
        while ((number /= 10) != 0) ++digits;
        return digits;
    }
}