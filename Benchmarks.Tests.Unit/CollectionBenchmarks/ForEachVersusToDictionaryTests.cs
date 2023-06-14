using Benchmarks.CollectionBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.CollectionBenchmarks;

public class ForEachVersusToDictionaryTests {
    private readonly ForEachVersusToDictionary _benchmark = new();

    [Fact]
    public void ForeachLoop_ShouldCreateDictionaryWithSameItems() {
        // Act
        Dictionary<string, ForEachVersusToDictionary.MockFileData> result = _benchmark.ForeachLoop();

        // Assert
        result.Should().BeEquivalentTo(CreateExpectedDictionary());
    }

    [Fact]
    public void ToDictionary_ShouldCreateDictionaryWithSameItems() {
        // Act
        Dictionary<string, ForEachVersusToDictionary.MockFileData> result = _benchmark.ToDictionary();

        // Assert
        result.Should().BeEquivalentTo(CreateExpectedDictionary());
    }

    private Dictionary<string, ForEachVersusToDictionary.MockFileData> CreateExpectedDictionary() {
        var inputDictionary = new Dictionary<string, string>(ForEachVersusToDictionary.Dictionary);
        var expectedDictionary = new Dictionary<string, ForEachVersusToDictionary.MockFileData>(inputDictionary.Count);

        foreach (var kvp in inputDictionary) {
            expectedDictionary.Add(kvp.Key, new ForEachVersusToDictionary.MockFileData(kvp.Value));
        }

        return expectedDictionary;
    }
}