namespace Miz.Util.IntExtensions.Test;

using Xunit;
using Miz.Util.IntExtensions;

public class IntDigitLengthTests
{
    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthLinearSearch(int number, int expectedLength) {
        int numberLength = number.DigitsLengthLinearSearch();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthSwitch(int number, int expectedLength) {
        int numberLength = number.DigitsLengthSwitch();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthBinarySearch(int number, int expectedLength) {
        int numberLength = number.DigitsLengthBinarySearch();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthLog2Lookup(int number, int expectedLength) {
        int numberLength = number.DigitsLengthLog2Lookup();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthConditonalLookup(int number, int expectedLength) {
        int numberLength = number.DigitsLengthConditonalLookup();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthToString(int number, int expectedLength) {
        int numberLength = number.DigitsLengthToString();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthLog10(int number, int expectedLength) {
        int numberLength = number.DigitsLengthLog10();
        Assert.Equal(expectedLength, numberLength);
    }

    [Theory, MemberData(nameof(IntDigitLengths))]
    public void DigitsLengthWhile(int number, int expectedLength) {
        int numberLength = number.DigitsLengthWhile();
        Assert.Equal(expectedLength, numberLength);
    }

    public static readonly TheoryData<int, int> IntDigitLengths = new() {
        {  1,           1 },
        {  10,          2 },
        {  100,         3 },
        {  1000,        4 },
        {  10000,       5 },
        {  100000,      6 },
        {  1000000,     7 },
        {  10000000,    8 },
        {  100000000,   9 },
        {  1000000000, 10 },
        { -1,           1 },
        { -10,          2 },
        { -100,         3 },
        { -1000,        4 },
        { -10000,       5 },
        { -100000,      6 },
        { -1000000,     7 },
        { -10000000,    8 },
        { -100000000,   9 },
        { -1000000000, 10 },
    };
}