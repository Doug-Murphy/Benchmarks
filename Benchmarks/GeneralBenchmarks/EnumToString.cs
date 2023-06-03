using System;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.GeneralBenchmarks {
    [MemoryDiagnoser]
    public class EnumToString {
        private readonly Animals _enumToUse = Animals.Dog;

        [Benchmark]
        public string EnumValueToString() {
            return _enumToUse.ToString();
        }

        [Benchmark]
        public string EnumValueStringInterpolation() {
            return $"Interpolated string {_enumToUse}";
        }

        [Benchmark]
        public string EnumValueStringConcatenation() {
            return "Concatenated string " + _enumToUse;
        }

        [Benchmark(Baseline = true)]
        public string EnumValueSwitchNameof() {
            switch (_enumToUse) {
                case Animals.Dog:
                    return nameof(Animals.Dog);
                case Animals.Cat:
                    return nameof(Animals.Cat);
                case Animals.Fish:
                    return nameof(Animals.Fish);
                default:
                    throw new ArgumentOutOfRangeException(nameof(_enumToUse));
            }
        }

        private enum Animals {
            Dog,
            Cat,
            Fish,
        }
    }
}
