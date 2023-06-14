using Benchmarks.StringBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.StringBenchmarks;

public class StringAsCharArrayTests {
    private const string MyString1 = "123";
    private const string MyString2 = "3";
    private readonly StringAsCharArray _benchmark = new();

    [Fact]
    public void StringSplitAny_ShouldReturnExpectedResult() {
        // Arrange
        var expected = MyString1.Split().Any(ch => MyString2.Contains(ch));

        // Act
        var result = _benchmark.StringSplitAny();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringToCharArrayAny_ShouldReturnExpectedResult() {
        // Arrange
        var expected = MyString1.ToCharArray().Any(ch => MyString2.Contains(ch));

        // Act
        var result = _benchmark.StringToCharArrayAny();

        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void StringAny_ShouldReturnExpectedResult() {
        // Arrange
        var expected = MyString1.Any(ch => MyString2.Contains(ch));

        // Act
        var result = _benchmark.StringAny();

        // Assert
        result.Should().Be(expected);
    }
}