using Benchmarks.GeneralBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.GeneralBenchmarks;

public class MultipleIfComparedToSwitchTests {
    private readonly MultipleIfComparedToSwitch _benchmark = new();

    [Fact]
    public void TenIfStatements_ShouldReturnModifiedValue() {
        // Act
        var result = _benchmark.TenIfStatements();

        // Assert
        result.Should().Be(20);
    }

    [Fact]
    public void TenIfElseIfStatements_ShouldReturnModifiedValue() {
        // Act
        var result = _benchmark.TenIfElseIfStatements();

        // Assert
        result.Should().Be(20);
    }

    [Fact]
    public void TenCaseStatements_ShouldReturnModifiedValue() {
        // Act
        var result = _benchmark.TenCaseStatements();

        // Assert
        result.Should().Be(20);
    }
}