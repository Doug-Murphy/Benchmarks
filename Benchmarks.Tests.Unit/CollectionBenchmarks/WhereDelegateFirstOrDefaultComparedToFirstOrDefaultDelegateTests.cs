using Benchmarks.CollectionBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.CollectionBenchmarks; 

public class WhereDelegateFirstOrDefaultComparedToFirstOrDefaultDelegateTests {
    private readonly WhereDelegateFirstOrDefaultComparedToFirstOrDefaultDelegate _benchmark = new();

    [Fact]
    public void WhereDelegateFirstOrDefault_ShouldReturnExpectedResult() {
        // Act
        var result = _benchmark.WhereDelegateFirstOrDefault();

        // Assert
        result.Should().BeGreaterThan(500_000);
    }

    [Fact]
    public void FirstOrDefaultDelegate_ShouldReturnExpectedResult() {
        // Act
        var result = _benchmark.FirstOrDefaultDelegate();

        // Assert
        result.Should().BeGreaterThan(500_000);
    }
}