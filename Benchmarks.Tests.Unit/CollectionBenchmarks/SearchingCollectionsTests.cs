using Benchmarks.CollectionBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.CollectionBenchmarks;

public class SearchingCollectionsTests {
    private readonly SearchingCollections _benchmark = new();

    [Fact]
    public void EnumerableContains_ShouldReturnTrueWhenItemIsPresent() {
        // Act
        var result = _benchmark.EnumerableContains();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ListContains_ShouldReturnTrueWhenItemIsPresent() {
        // Act
        var result = _benchmark.ListContains();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ListExists_ShouldReturnTrueWhenItemIsPresent() {
        // Act
        var result = _benchmark.ListExists();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void LinqAny_ShouldReturnTrueWhenItemIsPresent() {
        // Act
        var result = _benchmark.LinqAny();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void ForeachEquals_ShouldReturnTrueWhenItemIsPresent() {
        // Act
        var result = _benchmark.ForeachEquals();

        // Assert
        result.Should().BeTrue();
    }
}