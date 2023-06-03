using BenchmarkDotNet.Attributes;

namespace Benchmarks.ClassesRecordsBenchmarks {
    [MemoryDiagnoser]
    public class StaticMethodsVersusInstancedMethods {
        private readonly ClassWithMethods _classWithMethods = new ClassWithMethods();

        [Benchmark]
        public int InstancedMethodCall() {
            return _classWithMethods.InstancedMethod();
        }

        [Benchmark]
        public int InstancedMethodCallWithInstantiation() {
            return new ClassWithMethods().InstancedMethod();
        }

        [Benchmark]
        public int StaticMethodCall() {
            return ClassWithMethods.StaticMethod();
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