using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System.Collections.Generic;
using System.Linq;

namespace Benchmarks.Benchmarks {
	[MemoryDiagnoser]
	[Orderer(SummaryOrderPolicy.FastestToSlowest)]
	public class ForEachVersusToDictionary {
		private static readonly IDictionary<string, string> Dictionary = new Dictionary<string, string> {
			{"Key1", "Value1"},
			{"Key2", "Value2"},
			{"Key3", "Value3"},
			{"Key4", "Value4"},
			{"Key5", "Value5"},
			{"Key6", "Value6"},
			{"Key7", "Value7"},
			{"Key8", "Value8"},
			{"Key9", "Value9"},
			{"Key10", "Value10"},
		};

		[Benchmark]
		public Dictionary<string, MockFileData> ForeachLoop() {
			var newDictionary = new Dictionary<string, MockFileData>();
			foreach (KeyValuePair<string, string> keyValuePair in Dictionary) {
				newDictionary.Add(keyValuePair.Key, new MockFileData(keyValuePair.Value));
			}

			return newDictionary;
		}

		[Benchmark]
		public Dictionary<string, MockFileData> ToDictionary() {
			return Dictionary.ToDictionary(kvp => kvp.Key, kvp => new MockFileData(kvp.Value));
		}

		public class MockFileData {
			public MockFileData(string fileData) {
				FileData = fileData;
			}

			private string FileData { get; }
		}
	}
}
