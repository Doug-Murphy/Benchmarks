using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.LoopBenchmarks {
    [MemoryDiagnoser]
    public class ForLoopVersusForEach {
        private readonly List<int> _list = Enumerable.Range(1, 500).ToList();

        [Benchmark]
        public void ForEachLoop() {
            int iterations = 0;
            foreach (int item in _list) {
                iterations++;
            }
        }

        [Benchmark]
        public void ForLoop() {
            int iterations = 0;
            for (int i = 0; i < _list.Count; i++) {
                iterations++;
            }
        }
    }
}
