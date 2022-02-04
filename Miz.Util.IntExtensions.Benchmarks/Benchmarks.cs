namespace DigitLengthBenchmarks;

using System;
using System.Linq;

using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

using Miz.Util.IntExtensions;

public class Benchmarks
{
    static readonly Random RNG = new Random();
    static readonly int[] RandomInts = Enumerable.Range(0, 100000).Select(_ => RNG.Next(int.MinValue, int.MaxValue)).ToArray();
    // static int[] RandomIntsLengths = RandomInts.Select(number => number.DigitsLengthLinearSearch()).ToArray();
    // int[] SequentialPositiveInts = Enumerable.Range(0, 100000).ToArray();

    [Params(1000)]
    public int NumberOfTests { get; set; }

    [Benchmark(Baseline = true)]
    public int Log10() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthLog10();
        }
        return totalDigits;
    }

    [Benchmark]
    public int WhileDivision() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthWhileDivision();
        }
        return totalDigits;
    }

    [Benchmark]
    public int BinarySearch() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthBinarySearch();
        }
        return totalDigits;
    }

    [Benchmark]
    public int Switch() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthSwitch();
        }
        return totalDigits;
    }

    [Benchmark]
    public int LinearSearch() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthLinearSearch();
        }
        return totalDigits;
    }

    [Benchmark]
    public int ConditionalLookup() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthConditonalLookup();
        }
        return totalDigits;
    }

    [Benchmark]
    public int Log2Lookup() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthLog2Lookup();
        }
        return totalDigits;
    }

    [Benchmark]
    public int IntToString() {
        int totalDigits = 0;
        for (int index = 0; index < NumberOfTests; index++) {
            totalDigits += RandomInts[index].DigitsLengthToString();
        }
        return totalDigits;
    }
}
