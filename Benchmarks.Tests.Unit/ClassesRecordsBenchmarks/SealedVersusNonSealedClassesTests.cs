using Benchmarks.ClassesRecordsBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.ClassesRecordsBenchmarks;

public class SealedVersusNonSealedClassesTests {
    private readonly SealedVersusNonSealedClasses _benchmark = new();

    [Fact]
    public void SealedClassReferencing_ShouldReturn457() {
        var result = _benchmark.SealedClassReferencing();

        result.Should().Be(457);
    }

    [Fact]
    public void SealedMethodReferencing_ShouldReturn457() {
        var result = _benchmark.SealedMethodReferencing();

        result.Should().Be(457);
    }

    [Fact]
    public void NonSealedClassReferencing_ShouldReturn457() {
        var result = _benchmark.NonSealedClassReferencing();

        result.Should().Be(457);
    }
}