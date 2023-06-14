using BenchmarkDotNet.Attributes;

namespace Benchmarks.StringBenchmarks {
    [MemoryDiagnoser]
    public class StringEmptyVersusEmptyQuotes {
        [Benchmark]
        public string StringEmpty() {
            var foo = string.Empty;
            return foo + "bar";
        }

        [Benchmark]
        public string EmptyQuotes() {
            var foo = "";
            return foo + "bar";
        }
    }
}
