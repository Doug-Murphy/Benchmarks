using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.CollectionBenchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class LinqAnyVersusEnumerableContains {
        private readonly List<string> _list10000Items = Enumerable.Repeat("foo", 10_000).ToList();

        [Benchmark]
        public bool EnumerableContains() {
            return Enumerable.Contains(_list10000Items, "foo");
        }

        [Benchmark]
        public bool ListContains() {
            return _list10000Items.Contains("foo");
        }

        [Benchmark]
        public bool LinqAny() {
            return _list10000Items.Any(x => x == "foo");
        }

        [Benchmark]
        public bool ForeachEquals() {
            foreach (string item in _list10000Items) {
                if (Equals("foo", item)) {
                    return true;
                }
            }

            return false;
        }
    }
}
