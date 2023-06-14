using Benchmarks.GeneralBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.GeneralBenchmarks; 

public class TryCatchMethodCallStackTests {
    private readonly TryCatchMethodCallStack _benchmark = new();

    [Fact]
    public void TopLevelTryCatchOnly_ShouldNotThrowException() {
        // Act
        var act = () => _benchmark.TopLevelTryCatchOnly();

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void TopLevelAndChildLevelCatches_ShouldNotThrowException() {
        // Act
        var act = () => _benchmark.TopLevelAndChildLevelCatches();

        // Assert
        act.Should().NotThrow();
    }

    [Fact]
    public void TopLevelAndChildLevelCatchesWithThrowNew_ShouldNotThrowException() {
        // Act
        var act = () => _benchmark.TopLevelAndChildLevelCatchesWithThrowNew();

        // Assert
        act.Should().NotThrow();
    }
}