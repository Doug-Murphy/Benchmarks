using Benchmarks.ClassesRecordsBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.ClassesRecordsBenchmarks;

public class RecordValueChecksTests {
    private readonly RecordValueChecks _benchmark;

    public RecordValueChecksTests() {
        _benchmark = new RecordValueChecks();
    }

    [Fact]
    public void RecordCheckProperty1AllSameTest() {
        _benchmark.RecordCheckProperty1AllSame().Should().BeTrue();
    }

    [Fact]
    public void RecordCheckProperty10AllSameTest() {
        _benchmark.RecordCheckProperty10AllSame().Should().BeTrue();
    }

    [Fact]
    public void RecordCheckProperty20AllSameTest() {
        _benchmark.RecordCheckProperty20AllSame().Should().BeTrue();
    }

    [Fact]
    public void RecordCheckProperty30AllSameTest() {
        _benchmark.RecordCheckProperty30AllSame().Should().BeTrue();
    }

    [Fact]
    public void RecordCheckProperty20DifferAt10Test() {
        _benchmark.RecordCheckProperty20DifferAt10().Should().BeFalse();
    }

    [Fact]
    public void RecordCheckProperty30DifferAt20Test() {
        _benchmark.RecordCheckProperty30DifferAt20().Should().BeFalse();
    }

    [Fact]
    public void ClassCheckProperty30DifferAt20Test() {
        _benchmark.ClassCheckProperty30DifferAt20().Should().BeFalse();
    }
}