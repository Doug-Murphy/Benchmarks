using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser, Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    public class NullChecking {
        private Thing _thingInstance = null;

        [Benchmark]
        public void NotEqualNull() {
            if (_thingInstance != null) {
                _thingInstance.Do();
            }
        }

        [Benchmark]
        public void IsObject() {
            if (_thingInstance is object) {
                _thingInstance.Do();
            }
        }

#if NET5_0_OR_GREATER
        [Benchmark]
        public void IsNotNull() {
            if (_thingInstance is not null) {
                _thingInstance.Do();
            }
        }
#endif

#if NETCOREAPP3_1_OR_GREATER
        [Benchmark]
        public void IsCurlyBraces() {
            if (_thingInstance is { } t0) {
                t0.Do();
            }
        }

        [Benchmark]
        public void IsCurlyBracesDiscard() {
            if (_thingInstance is { }) {
                _thingInstance.Do();
            }
        }
#endif

        [Benchmark]
        public void IsThing() {
            if (_thingInstance is Thing t1) {
                t1.Do();
            }
        }

        [Benchmark]
        public void IsThingDiscard() {
            if (_thingInstance is Thing) {
                _thingInstance.Do();
            }
        }

        [Benchmark]
        public void NullPropagation() {
            _thingInstance?.Do();
        }

        private class Thing {
            public void Do() {
                //no-op
            }
        }
    }
}
