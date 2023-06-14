using Benchmarks.GeneralBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.GeneralBenchmarks;

public class EnumToStringTests {
    private readonly EnumToString _benchmark = new();

    [Fact]
    public void EnumValueToString_ShouldReturnEnumName() {
        // Act
        var result = _benchmark.EnumValueToString();

        // Assert
        result.Should().Be("Dog");
    }

    [Fact]
    public void EnumValueStringInterpolation_ShouldReturnInterpolatedString() {
        // Act
        var result = _benchmark.EnumValueStringInterpolation();

        // Assert
        result.Should().Be("Interpolated string Dog");
    }

    [Fact]
    public void EnumValueStringConcatenation_ShouldReturnConcatenatedString() {
        // Act
        var result = _benchmark.EnumValueStringConcatenation();

        // Assert
        result.Should().Be("Concatenated string Dog");
    }

    [Fact]
    public void EnumValueSwitchNameof_ShouldReturnEnumName() {
        // Act
        var result = _benchmark.EnumValueSwitchNameof();

        // Assert
        result.Should().Be("Dog");
    }
}