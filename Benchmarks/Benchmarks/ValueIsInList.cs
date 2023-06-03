using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class ValueIsInList {
        private static readonly List<string> fooList = Enumerable.Repeat("foo", 5_000).ToList();
        private static readonly List<string> barList = Enumerable.Repeat("bar", 5_000).ToList();
        private readonly List<string> list = fooList.Concat(barList).ToList();

        [Params("foo", "bar")]
        public string value;

        [Benchmark(Baseline = true)]
        public bool InBefore() {
            if (list == null || list.Count == 0) {
                return false;
            }
            return list.Contains(value);
        }

        [Benchmark]
        public bool InAfter() {
            if (list == null || list.Count == 0) {
                return false;
            }

            foreach (string item in list) {
                if (item.Equals(value)) {
                    return true;
                }
            }

            return false;
        }
    }
}
