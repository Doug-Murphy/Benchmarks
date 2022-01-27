using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.Benchmarks {
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    public class BatchVersusSplit {
        private readonly List<string> _batchEnumerable = Enumerable.Repeat("foo", 1_000).ToList();
        private readonly List<string> _splitEnumerable = Enumerable.Repeat("foo", 1_000).ToList();

        [Benchmark]
        public void Batch() {
            List<IEnumerable<string>> batchResult = Batch(_batchEnumerable, 100).ToList();
        }

        [Benchmark(Baseline = true)]
        public void Split() {
            List<IEnumerable<string>> splitResult = Split(_splitEnumerable, 100).ToList();
        }

        private static IEnumerable<IEnumerable<T>> Batch<T>(IEnumerable<T> collection, int batchSize) {
            var nextBatch = new List<T>(batchSize);
            foreach (T item in collection) {
                nextBatch.Add(item);
                if (nextBatch.Count == batchSize) {
                    yield return nextBatch;
                    nextBatch = new List<T>(batchSize);
                }
            }

            if (nextBatch.Count > 0) {
                yield return nextBatch;
            }
        }

        private static IEnumerable<IEnumerable<T>> Split<T>(IEnumerable<T> collection, int chunkSize) {
            if (chunkSize <= 0) {
                throw new ArgumentOutOfRangeException(nameof(chunkSize), $"{nameof(chunkSize)} must be greater than 0.");
            }

            int collectionSize = collection.Count();
            for (var i = 0; i < collectionSize; i += chunkSize) {
                yield return collection.Skip(i).Take(Math.Min(chunkSize, collectionSize - i));
            }
        }
    }
}
