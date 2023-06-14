using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.CollectionBenchmarks {
    [MemoryDiagnoser]
    public class ForLoopVersusForEach {
        private readonly List<int> _list = Enumerable.Range(1, 500).ToList();

        [Benchmark]
        public int ForEachLoop() {
            int iterations = 0;
            foreach (int item in _list) {
                iterations++;
            }

            return iterations;
        }

        [Benchmark]
        public int ForLoop() {
            int iterations = 0;
            for (int i = 0; i < _list.Count; i++) {
                iterations++;
            }

            return iterations;
        }
    }
}
