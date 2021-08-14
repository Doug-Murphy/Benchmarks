using BenchmarkDotNet.Attributes;
using System.Collections.Immutable;
using System.Linq;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class WhereDelegateFirstOrDefaultComparedToFirstOrDefaultDelegate {
        private readonly ImmutableList<int> _list = Enumerable.Range(0, 1_000_000).ToImmutableList();

        [Benchmark]
        public int WhereDelegateFirstOrDefault() {
            return _list.Where(x => x > 500_000).FirstOrDefault();
        }

        [Benchmark]
        public int FirstOrDefaultDelegate() {
            return _list.FirstOrDefault(x => x > 500_000);
        }
    }
}
