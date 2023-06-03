using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class GetTypeNameVersusNameof {
        [Benchmark]
        public string GetTypeWithName() {
            return GetType().Name;
        }

        [Benchmark(Baseline = true)]
        public string NameofClass() {
            return nameof(GetTypeNameVersusNameof);
        }
    }
}
