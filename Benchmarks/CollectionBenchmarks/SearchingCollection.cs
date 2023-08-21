using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.CollectionBenchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class SearchingCollections {
        private readonly List<int> _list = Enumerable.Range(1, 1_000_000).ToList();

        [Benchmark]
        public bool EnumerableContains() {
            return Enumerable.Contains(_list, 999_999);
        }

        [Benchmark]
        public bool ListContains() {
            return _list.Contains(999_999);
        }

        [Benchmark]
        public bool ListExists() {
            return _list.Exists(x => x == 999_999);
        }

        [Benchmark]
        public bool LinqAny() {
            return _list.Any(x => x == 999_999);
        }

        [Benchmark]
        public bool ForeachEquals() {
            foreach (var item in _list) {
                if (Equals(999_999, item)) {
                    return true;
                }
            }

            return false;
        }
    }
}
