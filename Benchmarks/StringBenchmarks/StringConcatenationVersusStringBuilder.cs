using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.StringBenchmarks {
    [MemoryDiagnoser]
    public class StringConcatenationVersusStringBuilder {
        [Params(1, 5, 10, 100)]
        public int NumberOfIterations = 100;

        [Benchmark]
        public string StringBuilder() {
            var stringToReturn = new StringBuilder();

            for (var i = 0; i < NumberOfIterations; i++) {
                stringToReturn.Append(i);
            }

            return stringToReturn.ToString();
        }

        [Benchmark]
        public string StringConcatenation() {
            string stringToReturn = null;

            for (var i = 0; i < NumberOfIterations; i++) {
                stringToReturn += i;
            }

            return stringToReturn;
        }
    }
}
