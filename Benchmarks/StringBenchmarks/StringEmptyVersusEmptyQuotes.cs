using BenchmarkDotNet.Attributes;

namespace Benchmarks.StringBenchmarks {
    [MemoryDiagnoser]
    public class StringEmptyVersusEmptyQuotes {
        [Benchmark]
        public void StringEmpty() {
            var foo = string.Empty;
            string bar = foo + "bar";
        }

        [Benchmark]
        public void EmptyQuotes() {
            var foo = "";
            string bar = foo + "bar";
        }
    }
}
