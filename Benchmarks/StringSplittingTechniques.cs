#if NET5_0_OR_GREATER
using BenchmarkDotNet.Attributes;
using System;

namespace Benchmarks.Benchmarks {
    /// <summary>
    /// A benchmark to compare various ways of splitting a string to extract certain parts.
    /// </summary>
    [MemoryDiagnoser]
    public class StringSplittingTechniques {
        private const string _testString = "123 456 789";

        [Benchmark]
        public (int num1, int num2, int num3) StringSubstring() {
            int firstNum = int.Parse(_testString.Substring(0, 3));
            int secondNum = int.Parse(_testString.Substring(4, 3));
            int thirdNum = int.Parse(_testString.Substring(8, 3));

            return (firstNum, secondNum, thirdNum);
        }

        [Benchmark]
        public (int num1, int num2, int num3) StringSpanSlice() {
            ReadOnlySpan<char> stringAsSpan = _testString.AsSpan();

            int firstNum = int.Parse(stringAsSpan.Slice(0, 3));
            int secondNum = int.Parse(stringAsSpan.Slice(4, 3));
            int thirdNum = int.Parse(stringAsSpan.Slice(8, 3));

            return (firstNum, secondNum, thirdNum);
        }

        [Benchmark]
        public (int num1, int num2, int num3) StringSplitTriple() {
            int firstNum = int.Parse(_testString.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0]);
            int secondNum = int.Parse(_testString.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
            int thirdNum = int.Parse(_testString.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);

            return (firstNum, secondNum, thirdNum);
        }

        [Benchmark]
        public (int num1, int num2, int num3) StringSplitSingle() {
            string[] splitString = _testString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int firstNum = int.Parse(splitString[0]);
            int secondNum = int.Parse(splitString[1]);
            int thirdNum = int.Parse(splitString[2]);

            return (firstNum, secondNum, thirdNum);
        }
    }
}
#endif