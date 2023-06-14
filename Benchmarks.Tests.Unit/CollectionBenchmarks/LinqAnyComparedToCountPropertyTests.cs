using Benchmarks.CollectionBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.CollectionBenchmarks; 

public class LinqAnyComparedToCountPropertyTests {
    private readonly LinqAnyComparedToCountProperty _benchmark = new();

    [Fact]
    public void LinqAny_ShouldReturnTrueWhenListIsNotEmpty() {
        // Act
        var result = _benchmark.LinqAny();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void CountProperty_ShouldReturnTrueWhenListIsNotEmpty() {
        // Act
        var result = _benchmark.CountProperty();

        // Assert
        result.Should().BeTrue();
    }
}