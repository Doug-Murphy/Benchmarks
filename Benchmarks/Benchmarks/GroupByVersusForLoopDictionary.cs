using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks {
	/// <summary>
	/// Question: How long does it take to turn an enumerable into a dictionary key'd off of one of the enumerable's properties
	/// Methods: 
	///		ForLoopDictionary - Have a dictionary, do lookup/insert of the key in a for loop
	///		GroupBy (Linq) - Run GroupBy, then ToDictionary linq methods
	/// Data: All keys are ints
	///		DistinctList - No repeated keys in list
	///		AllSameKey - Only 1 repeated key in list
	///		100Keys - 100 possible keys, repeated via modulo throughout the source list
	/// </summary>
	[MemoryDiagnoser]
	public class GroupByVersusForLoopDictionary {
		private const int ListSize = 100_000;

		private List<(int, string)> distinctList = Enumerable.Range(0, ListSize).Select(x => (x, x.ToString())).ToList();
		private List<(int, string)> allSameKey = Enumerable.Range(0, ListSize).Select(x => (1, x.ToString())).ToList();
		private List<(int, string)> oneHundredBucketChallenge = Enumerable.Range(0, ListSize).Select(x => (x % 100, x.ToString())).ToList();
		
		[ParamsAllValues]
		public GroupByVersusForLoopDictionaryKeyDensity ListKeyDensity { get; set; }
		
		[Benchmark]
		public Dictionary<int, List<(int, String)>> GroupByDictionary() {
			var actionableList = Router(ListKeyDensity);
			return actionableList.GroupBy(x => x.Item1).ToDictionary(x => x.Key, x => x.ToList());
		}
		
		[Benchmark]
		public Dictionary<int, List<(int, String)>> ForLoopDictionary() {
			var actionableList = Router(ListKeyDensity);
			var ret = new Dictionary<int, List<(int, string)>>();
			foreach (var item in actionableList) {
				if (!ret.TryGetValue(item.Item1, out List<(int, string)> childList)) {
					childList = new List<(int, string)>();
					ret.Add(item.Item1, childList);
				}
				childList.Add(item);
			}
			return ret;
		}


		public List<(int, string)> Router(GroupByVersusForLoopDictionaryKeyDensity listKeyDensity) {
			switch (listKeyDensity) {
				case GroupByVersusForLoopDictionaryKeyDensity.DistinctList:
					return distinctList;
				case GroupByVersusForLoopDictionaryKeyDensity.AllSameKey:
					return allSameKey;
				case GroupByVersusForLoopDictionaryKeyDensity.OneHundredBucketChallenge:
					return oneHundredBucketChallenge;
				default:
					throw new ArgumentOutOfRangeException($"enum value {listKeyDensity} is unrouted");
			}
		}
		
	}

	public enum GroupByVersusForLoopDictionaryKeyDensity {
		DistinctList,
		AllSameKey,
		OneHundredBucketChallenge
	}
}
