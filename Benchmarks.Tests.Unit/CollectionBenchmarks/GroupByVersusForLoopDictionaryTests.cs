using Benchmarks.CollectionBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.CollectionBenchmarks;

public class GroupByVersusForLoopDictionaryTests {
    private readonly GroupByVersusForLoopDictionary _benchmark = new();

    [Theory]
    [InlineData(GroupByVersusForLoopDictionaryKeyDensity.DistinctList)]
    [InlineData(GroupByVersusForLoopDictionaryKeyDensity.AllSameKey)]
    [InlineData(GroupByVersusForLoopDictionaryKeyDensity.OneHundredBucketChallenge)]
    public void GroupByDictionary_ShouldCreateDictionaryWithExpectedKeys(GroupByVersusForLoopDictionaryKeyDensity keyDensity) {
        //Arrange
        _benchmark.ListKeyDensity = keyDensity;

        // Act
        Dictionary<int, List<(int, string)>> result = _benchmark.GroupByDictionary();

        // Assert
        var expectedDictionary = CreateExpectedDictionary(_benchmark);
        result.Should().BeEquivalentTo(expectedDictionary);
    }

    [Theory]
    [InlineData(GroupByVersusForLoopDictionaryKeyDensity.DistinctList)]
    [InlineData(GroupByVersusForLoopDictionaryKeyDensity.AllSameKey)]
    [InlineData(GroupByVersusForLoopDictionaryKeyDensity.OneHundredBucketChallenge)]
    public void ForLoopDictionary_ShouldCreateDictionaryWithExpectedKeys(GroupByVersusForLoopDictionaryKeyDensity keyDensity) {
        //Arrange
        _benchmark.ListKeyDensity = keyDensity;

        // Act
        Dictionary<int, List<(int, string)>> result = _benchmark.ForLoopDictionary();

        // Assert
        var expectedDictionary = CreateExpectedDictionary(_benchmark);
        result.Should().BeEquivalentTo(expectedDictionary);
    }

    private Dictionary<int, List<(int, string)>> CreateExpectedDictionary(GroupByVersusForLoopDictionary benchmark) {
        List<(int, string)> actionableList = benchmark.Router(benchmark.ListKeyDensity);
        var expectedDictionary = new Dictionary<int, List<(int, string)>>(actionableList.Count);

        foreach (var item in actionableList) {
            if (!expectedDictionary.TryGetValue(item.Item1, out var childList)) {
                childList = new List<(int, string)>();
                expectedDictionary.Add(item.Item1, childList);
            }

            childList.Add(item);
        }

        return expectedDictionary;
    }
}