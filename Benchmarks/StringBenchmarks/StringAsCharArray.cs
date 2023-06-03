using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.StringBenchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class StringAsCharArray {
        private const string MyString1 = "123";
        private const string MyString2 = "3";

        [Benchmark]
        public bool StringSplitAny() {
            return MyString1.Split().Any(ch => MyString2.Contains(ch));
        }

        [Benchmark]
        public bool StringToCharArrayAny() {
            return MyString1.ToCharArray().Any(ch => MyString2.Contains(ch));
        }

        [Benchmark]
        public bool StringAny() {
            return MyString1.Any(ch => MyString2.Contains(ch));
        }
    }
}