using BenchmarkDotNet.Attributes;

namespace Benchmarks.ClassesRecordsBenchmarks {
    [MemoryDiagnoser]
    public class StaticMethodsVersusInstancedMethods {
        private readonly ClassWithMethods _classWithMethods = new ClassWithMethods();

        [Benchmark]
        public void InstancedMethodCall() {
            _classWithMethods.InstancedMethod();
        }

        [Benchmark]
        public void InstancedMethodCallWithInstantiation() {
            new ClassWithMethods().InstancedMethod();
        }

        [Benchmark]
        public void StaticMethodCall() {
            ClassWithMethods.StaticMethod();
        }

        private class ClassWithMethods {
            public int InstancedMethod() {
                return 42;
            }

            public static int StaticMethod() {
                return 42;
            }
        }
    }
}