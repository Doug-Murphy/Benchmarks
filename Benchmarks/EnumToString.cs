using BenchmarkDotNet.Attributes;
using System;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class EnumToString {
        [Params(Animals.Dog)]
        public Animals _enumToUse;

        [Benchmark]
        public string EnumValueToString() {
            return _enumToUse.ToString();
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
                    throw new Exception("Invalid enum option.");
            }
        }

        public enum Animals {
            Dog,
            Cat,
            Fish
        }
    }
}
