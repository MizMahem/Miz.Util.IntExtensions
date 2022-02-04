namespace Miz.Util.IntExtensions;

public static partial class IntExtensions
{
    public static int DigitsLengthLog2Lookup(this uint number)
        => (int)((number + Lookups[System.Numerics.BitOperations.Log2(number)]) >> 32);

    public static int DigitsLengthLog2Lookup(this int number) 
        => number >= 0 ? ((uint)number).DigitsLengthLog2Lookup() : ((uint)-number).DigitsLengthLog2Lookup();

    readonly static ulong[] Lookups = {
      4294967296,  8589934582,  8589934582,  8589934582,  12884901788,
      12884901788, 12884901788, 17179868184, 17179868184, 17179868184,
      21474826480, 21474826480, 21474826480, 21474826480, 25769703776,
      25769703776, 25769703776, 30063771072, 30063771072, 30063771072,
      34349738368, 34349738368, 34349738368, 34349738368, 38554705664,
      38554705664, 38554705664, 41949672960, 41949672960, 41949672960,
      42949672960, 42949672960
    };
}