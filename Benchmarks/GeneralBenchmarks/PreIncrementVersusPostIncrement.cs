using BenchmarkDotNet.Attributes;

namespace Benchmarks.GeneralBenchmarks {
    [MemoryDiagnoser]
    public class PreIncrementVersusPostIncrement {
        private const int NUM_ITERATIONS = 1_000_000;

        [Benchmark]
        public void PreIncrement() {
            int counter = 0;
            for (int i = 0; i < NUM_ITERATIONS; ++i) {
                counter = i;
            }
        }

        [Benchmark]
        public void PostIncrement() {
            int counter = 0;
            for (int i = 0; i < NUM_ITERATIONS; i++) {
                counter = i;
            }
        }
    }
}
