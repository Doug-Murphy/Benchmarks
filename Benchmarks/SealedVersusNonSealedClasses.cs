using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class SealedVersusNonSealedClasses {
        private readonly SealedClass _sealedClass = new SealedClass();

        private readonly SealedMethod _sealedMethod = new SealedMethod();

        private readonly NonSealedClass _nonSealedClass = new NonSealedClass();

        [Benchmark]
        public int SealedClassReferencing() {
            return _sealedClass.Foo() + 1;
        }
        
        [Benchmark]
        public int SealedMethodReferencing() {
            return _sealedMethod.Foo() + 1;
        }

        [Benchmark(Baseline = true)]
        public int NonSealedClassReferencing() {
            return _nonSealedClass.Foo() + 1;
        }

        private class BaseClass {
            public virtual int Foo() {
                return 123;
            }
        }

        private sealed class SealedClass : BaseClass {
            public override int Foo() {
                return 456;
            }
        }
        
        private class SealedMethod : BaseClass {
            public sealed override int Foo() {
                return 456;
            }
        }

        private class NonSealedClass : BaseClass {
            public override int Foo() {
                return 456;
            }
        }
    }
}