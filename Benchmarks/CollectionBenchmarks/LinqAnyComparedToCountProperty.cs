using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Benchmarks.CollectionBenchmarks {
    [MemoryDiagnoser]
    public class LinqAnyComparedToCountProperty {
        private readonly ImmutableList<int> _list = new List<int> {1, 2, 3, 4, 5}.ToImmutableList();

        [Benchmark]
        public bool LinqAny() {
            return _list.Any();
        }

        [Benchmark]
        public bool CountProperty() {
            return _list.Count > 0;
        }
    }
}