using Benchmarks.GeneralBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.GeneralBenchmarks; 

public class PreIncrementVersusPostIncrementTests {
    private readonly PreIncrementVersusPostIncrement _benchmark = new();

    [Fact]
    public void PreIncrement_ShouldReturnCounter() {
        // Act
        var result = _benchmark.PreIncrement();

        // Assert
        result.Should().Be(999_999);
    }

    [Fact]
    public void PostIncrement_ShouldReturnCounter() {
        // Act
        var result = _benchmark.PostIncrement();

        // Assert
        result.Should().Be(999_999);
    }
}