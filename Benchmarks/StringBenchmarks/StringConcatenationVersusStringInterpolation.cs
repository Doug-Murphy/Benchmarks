using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.StringBenchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class StringConcatenationVersusStringInterpolation {
        private const int ONE = 1;
        private const int TWO = 2;
        private const int THREE = 3;
        private const int FOUR = 4;
        private const int FIVE = 5;

        [Benchmark]
        public string StringConcatenationOneTime() {
            return "This is string concatenation to show that ONE is " + ONE;
        }

        [Benchmark]
        public string StringInterpolationOneTime() {
            return $"This is string interpolation to show that ONE is {ONE}";
        }

        [Benchmark]
        public string StringConcatenationTwoTimes() {
            return "This is string concatenation to show that ONE is " + ONE + " and that TWO is " + TWO;
        }

        [Benchmark]
        public string StringInterpolationTwoTimes() {
            return $"This is string interpolation to show that ONE is {ONE} and that TWO is {TWO}";
        }

        [Benchmark]
        public string StringConcatenationThreeTimes() {
            return "This is string concatenation to show that ONE is " + ONE + " and that TWO is " + TWO + " and that THREE is " + THREE;
        }

        [Benchmark]
        public string StringInterpolationThreeTimes() {
            return $"This is string interpolation to show that ONE is {ONE} and that TWO is {TWO} and that THREE is {THREE}";
        }

        [Benchmark]
        public string StringConcatenationFourTimes() {
            return "This is string concatenation to show that ONE is " + ONE + " and that TWO is " + TWO + " and that THREE is " + THREE + " and that FOUR is " + FOUR;
        }

        [Benchmark]
        public string StringInterpolationFourTimes() {
            return $"This is string interpolation to show that ONE is {ONE} and that TWO is {TWO} and that THREE is {THREE} and that FOUR is {FOUR}";
        }

        [Benchmark]
        public string StringConcatenationFiveTimes() {
            return "This is string concatenation to show that ONE is " + ONE + " and that TWO is " + TWO + " and that THREE is " + THREE + " and that FOUR is " + FOUR + " and that FIVE is " + FIVE;
        }

        [Benchmark]
        public string StringInterpolationFiveTimes() {
            return $"This is string interpolation to show that ONE is {ONE} and that TWO is {TWO} and that THREE is {THREE} and that FOUR is {FOUR} and that FIVE is {FIVE}";
        }
    }
}
