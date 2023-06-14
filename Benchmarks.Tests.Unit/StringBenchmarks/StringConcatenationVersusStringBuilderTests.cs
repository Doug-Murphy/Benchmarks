using Benchmarks.StringBenchmarks;
using FluentAssertions;
using System.Text;

namespace Benchmarks.Tests.Unit.StringBenchmarks; 

public class StringConcatenationVersusStringBuilderTests {
    private readonly StringConcatenationVersusStringBuilder _benchmark = new();

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(100)]
    public void StringBuilder_ShouldReturnExpectedResult(int numberOfIterations) {
        // Arrange
        _benchmark.NumberOfIterations = numberOfIterations;
        var expected = GenerateExpectedString(numberOfIterations);

        // Act
        var result = _benchmark.StringBuilder();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(5)]
    [InlineData(10)]
    [InlineData(100)]
    public void StringConcatenation_ShouldReturnExpectedResult(int numberOfIterations) {
        // Arrange
        _benchmark.NumberOfIterations = numberOfIterations;
        var expected = GenerateExpectedString(numberOfIterations);

        // Act
        var result = _benchmark.StringConcatenation();

        // Assert
        result.Should().Be(expected);
    }

    private static string GenerateExpectedString(int numberOfIterations) {
        var stringToReturn = new StringBuilder();

        for (var i = 0; i < numberOfIterations; i++) {
            stringToReturn.Append(i);
        }

        return stringToReturn.ToString();
    }
}