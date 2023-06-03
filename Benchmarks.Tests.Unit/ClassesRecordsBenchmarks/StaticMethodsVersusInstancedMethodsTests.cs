using Benchmarks.ClassesRecordsBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.ClassesRecordsBenchmarks;

public class StaticMethodsVersusInstancedMethodsTests {
    private readonly StaticMethodsVersusInstancedMethods _benchmark = new();

    [Fact]
    public void InstancedMethodCall_ShouldReturn42() {
        var result = _benchmark.InstancedMethodCall();

        result.Should().Be(42);
    }

    [Fact]
    public void InstancedMethodCallWithInstantiation_ShouldReturn42() {
        var result = _benchmark.InstancedMethodCallWithInstantiation();

        result.Should().Be(42);
    }

    [Fact]
    public void StaticMethodCall_ShouldReturn42() {
        var result = _benchmark.StaticMethodCall();

        result.Should().Be(42);
    }
}