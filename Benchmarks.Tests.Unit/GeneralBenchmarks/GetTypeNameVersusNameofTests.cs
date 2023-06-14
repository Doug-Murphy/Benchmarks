using Benchmarks.GeneralBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.GeneralBenchmarks; 

public class GetTypeNameVersusNameofTests {
    private readonly GetTypeNameVersusNameof _benchmark = new();

    [Fact]
    public void GetTypeWithName_ShouldReturnClassName() {
        // Act
        var result = _benchmark.GetTypeWithName();

        // Assert
        result.Should().Be("GetTypeNameVersusNameof");
    }

    [Fact]
    public void NameofClass_ShouldReturnClassName() {
        // Act
        var result = _benchmark.NameofClass();

        // Assert
        result.Should().Be("GetTypeNameVersusNameof");
    }
}