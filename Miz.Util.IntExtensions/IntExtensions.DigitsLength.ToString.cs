namespace Miz.Util.IntExtensions;

public static partial class IntExtensions
{
    public static int DigitsLengthToString(this int number) 
        => number >= 0 ? number.ToString().Length : number.ToString().Length - 1;
}