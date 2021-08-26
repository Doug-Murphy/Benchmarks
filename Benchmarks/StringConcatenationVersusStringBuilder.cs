using BenchmarkDotNet.Attributes;
using System.Text;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class StringConcatenationVersusStringBuilder {
        private const int NUM_OF_ITERATIONS = 100;

        [Benchmark]
        public string StringBuilder() {
            var stringToReturn = new StringBuilder();

            for (var i = 0; i < NUM_OF_ITERATIONS; i++) {
                stringToReturn.Append(i);
            }

            return stringToReturn.ToString();
        }

        [Benchmark]
        public string StringConcatenation() {
            string stringToReturn = null;

            for (var i = 0; i < NUM_OF_ITERATIONS; i++) {
                stringToReturn += i;
            }

            return stringToReturn;
        }
    }
}
