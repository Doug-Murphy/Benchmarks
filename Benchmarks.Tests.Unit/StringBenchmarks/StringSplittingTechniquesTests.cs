using Benchmarks.StringBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.StringBenchmarks;

public class StringSplittingTechniquesTests {
    private const int ExpectedNum1 = 123;
    private const int ExpectedNum2 = 456;
    private const int ExpectedNum3 = 789;
    private readonly StringSplittingTechniques _benchmark = new();

    [Fact]
    public void StringSubstring_ShouldReturnExpectedResult() {
        // Act
        var (resultNum1, resultNum2, resultNum3) = _benchmark.StringSubstring();

        // Assert
        resultNum1.Should().Be(ExpectedNum1);
        resultNum2.Should().Be(ExpectedNum2);
        resultNum3.Should().Be(ExpectedNum3);
    }

    [Fact]
    public void StringSplitTriple_ShouldReturnExpectedResult() {
        // Act
        var (resultNum1, resultNum2, resultNum3) = _benchmark.StringSplitTriple();

        // Assert
        resultNum1.Should().Be(ExpectedNum1);
        resultNum2.Should().Be(ExpectedNum2);
        resultNum3.Should().Be(ExpectedNum3);
    }

    [Fact]
    public void StringSplitSingle_ShouldReturnExpectedResult() {
        // Act
        var (resultNum1, resultNum2, resultNum3) = _benchmark.StringSplitSingle();

        // Assert
        resultNum1.Should().Be(ExpectedNum1);
        resultNum2.Should().Be(ExpectedNum2);
        resultNum3.Should().Be(ExpectedNum3);
    }

#if !NETFRAMEWORK
    [Fact]
    public void StringSpanSlice_ShouldReturnExpectedResult() {
        // Act
        var (resultNum1, resultNum2, resultNum3) = _benchmark.StringSpanSlice();

        // Assert
        resultNum1.Should().Be(ExpectedNum1);
        resultNum2.Should().Be(ExpectedNum2);
        resultNum3.Should().Be(ExpectedNum3);
    }
#endif
}