using Benchmarks.StringBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.StringBenchmarks; 

public class StringEmptyVersusEmptyQuotesTests {
    private readonly StringEmptyVersusEmptyQuotes _benchmark = new();

    [Fact]
    public void StringEmpty_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "bar";

        // Act
        var result = _benchmark.StringEmpty();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void EmptyQuotes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "bar";

        // Act
        var result = _benchmark.EmptyQuotes();

        // Assert
        result.Should().Be(expected);
    }
}