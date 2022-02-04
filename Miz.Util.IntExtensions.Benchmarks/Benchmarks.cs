namespace DigitLengthBenchmarks;

using System;
using System.Linq;

using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;

using Miz.Util.IntExtensions;

public class Benchmarks
{
    static Random RNG = new Random();
    int[] RandomInts = Enumerable.Range(0, 100000).Select(_ => RNG.Next(int.MinValue, int.MaxValue)).ToArray();
    int[] SequentialPositiveInts = Enumerable.Range(0, 100000).ToArray();

    [Params(1000)]
    public int NumberOfTests { get; set; }

    [Benchmark(Baseline = true)]
    public void Log10() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthLog10();
        }
    }

    [Benchmark]
    public void While() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthWhile();
        }
    }

    [Benchmark]
    public void BinarySearch() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthBinarySearch();
        }
    }

    [Benchmark]
    public void Switch() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthSwitch();
        }
    }

    [Benchmark]
    public void LinearSearch() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthLinearSearch();
        }
    }

    [Benchmark]
    public void ConditionalLookup() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthConditonalLookup();
        }
    }

    [Benchmark]
    public void Log2Lookup() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].DigitsLengthLog2Lookup();
        }
    }

    [Benchmark]
    public void IntToString() {
        for (int index = 0; index < NumberOfTests; index++) {
            RandomInts[index].ToString();
        }
    }

}
