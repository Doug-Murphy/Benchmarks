using Benchmarks.StringBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.StringBenchmarks; 

public class StringConcatenationVersusStringInterpolationTests {
    private readonly StringConcatenationVersusStringInterpolation _benchmark = new();

    [Fact]
    public void StringConcatenationOneTime_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string concatenation to show that ONE is 1";

        // Act
        var result = _benchmark.StringConcatenationOneTime();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringInterpolationOneTime_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string interpolation to show that ONE is 1";

        // Act
        var result = _benchmark.StringInterpolationOneTime();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringConcatenationTwoTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string concatenation to show that ONE is 1 and that TWO is 2";

        // Act
        var result = _benchmark.StringConcatenationTwoTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringInterpolationTwoTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string interpolation to show that ONE is 1 and that TWO is 2";

        // Act
        var result = _benchmark.StringInterpolationTwoTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringConcatenationThreeTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string concatenation to show that ONE is 1 and that TWO is 2 and that THREE is 3";

        // Act
        var result = _benchmark.StringConcatenationThreeTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringInterpolationThreeTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string interpolation to show that ONE is 1 and that TWO is 2 and that THREE is 3";

        // Act
        var result = _benchmark.StringInterpolationThreeTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringConcatenationFourTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string concatenation to show that ONE is 1 and that TWO is 2 and that THREE is 3 and that FOUR is 4";

        // Act
        var result = _benchmark.StringConcatenationFourTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringInterpolationFourTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string interpolation to show that ONE is 1 and that TWO is 2 and that THREE is 3 and that FOUR is 4";

        // Act
        var result = _benchmark.StringInterpolationFourTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringConcatenationFiveTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string concatenation to show that ONE is 1 and that TWO is 2 and that THREE is 3 and that FOUR is 4 and that FIVE is 5";

        // Act
        var result = _benchmark.StringConcatenationFiveTimes();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringInterpolationFiveTimes_ShouldReturnExpectedResult() {
        // Arrange
        var expected = "This is string interpolation to show that ONE is 1 and that TWO is 2 and that THREE is 3 and that FOUR is 4 and that FIVE is 5";

        // Act
        var result = _benchmark.StringInterpolationFiveTimes();

        // Assert
        result.Should().Be(expected);
    }
}