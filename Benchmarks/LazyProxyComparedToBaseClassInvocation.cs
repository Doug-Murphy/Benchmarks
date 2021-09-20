using BenchmarkDotNet.Attributes;
using System.Collections.Immutable;
using System.Linq;
using LazyProxy;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    public class LazyProxyComparedToBaseClassInvocation
    {
        private readonly ITestClass _sharedBase = new TestClass();
        private readonly ITestClass _sharedLazy = LazyProxyBuilder.CreateInstance<ITestClass>(() => new TestClass());
        
        [Benchmark]
        public int BaseInstance()
        {
            var testClass = new TestClass();
            return testClass.GetValue(5);
        }

        [Benchmark]
        public int LazyInstance()
        {
            var lazyClass = LazyProxyBuilder.CreateInstance<ITestClass>(() => new TestClass());
            return lazyClass.GetValue(5);
        }
        
        [Benchmark(Baseline = true)]
        public int BaseSharedInstance()
        {
            return _sharedBase.GetValue(5);
        }

        [Benchmark]
        public int LazySharedInstance()
        {
            return _sharedLazy.GetValue(5);
        }
        
        

        private class TestClass : ITestClass {
            public int GetValue(int value) {
                return value;
            }
        }
    }

    public interface ITestClass {
        int GetValue(int value);
    }
}
