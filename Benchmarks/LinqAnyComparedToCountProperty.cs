using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class LinqAnyComparedToCountProperty {
        private readonly ImmutableList<int> _list = new List<int> { 1, 2, 3, 4, 5 }.ToImmutableList();

        [Benchmark]
        public void LinqAny() {
            bool containsElements = _list.Any();
        }

        [Benchmark]
        public void CountProperty() {
            bool containsElements = _list.Count > 0;
        }
    }
}
