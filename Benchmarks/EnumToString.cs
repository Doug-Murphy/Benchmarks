using BenchmarkDotNet.Attributes;
using System;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class EnumToString {
        [Benchmark]
        public string EnumValueToString() {
            return Animals.Dog.ToString();
        }

        [Benchmark]
        public string EnumValueSwitchNameof() {
            Animals enumToUse = Animals.Dog;
            switch (enumToUse) {
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


        private enum Animals {
            Dog,
            Cat,
            Fish
        }
    }
}
