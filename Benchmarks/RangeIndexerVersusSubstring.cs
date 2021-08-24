#if !NETFRAMEWORK
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class RangeIndexerVersusSubstring {
        private const string TEST_STRING = "This is a string.";

        [Benchmark]
        public string RangeIndexer() {
            return TEST_STRING[TEST_STRING.LastIndexOf(" ")..];
        }

        [Benchmark(Baseline = true)]
        public string Substring() {
            return TEST_STRING.Substring(TEST_STRING.LastIndexOf(" "));
        }
    }
}
#endif