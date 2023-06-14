using Benchmarks.CollectionBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.CollectionBenchmarks;

public class ForLoopVersusForEachTests {
    private const int ExpectedIterations = 500;
    private readonly ForLoopVersusForEach _benchmark = new();

    [Fact]
    public void ForEachLoop_ShouldReturnExpectedIterations() {
        // Act
        var iterations = _benchmark.ForEachLoop();

        // Assert
        iterations.Should().Be(ExpectedIterations);
    }

    [Fact]
    public void ForLoop_ShouldReturnExpectedIterations() {
        // Act
        var iterations = _benchmark.ForLoop();

        // Assert
        iterations.Should().Be(ExpectedIterations);
    }
}