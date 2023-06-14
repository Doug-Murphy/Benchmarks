using Benchmarks.GeneralBenchmarks;

namespace Benchmarks.Tests.Unit.GeneralBenchmarks;

public class NullCheckingTests {
    private readonly NullChecking _benchmark = new();

    [Fact]
    public void NotEqualNull_ShouldExecuteDoMethod() {
        // Act
        _benchmark.NotEqualNull();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }

    [Fact]
    public void IsObject_ShouldExecuteDoMethod() {
        // Act
        _benchmark.IsObject();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }

#if NET5_0_OR_GREATER
    [Fact]
    public void IsNotNull_ShouldExecuteDoMethod() {
        // Act
        _benchmark.IsNotNull();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }
#endif

    [Fact]
    public void IsThing_ShouldExecuteDoMethod() {
        // Act
        _benchmark.IsThing();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }

    [Fact]
    public void IsThingDiscard_ShouldExecuteDoMethod() {
        // Act
        _benchmark.IsThingDiscard();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }

    [Fact]
    public void NullPropagation_ShouldExecuteDoMethod() {
        // Act
        _benchmark.NullPropagation();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }

#if NETCOREAPP3_1_OR_GREATER
    [Fact]
    public void IsCurlyBraces_ShouldExecuteDoMethod() {
        // Act
        _benchmark.IsCurlyBraces();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }

    [Fact]
    public void IsCurlyBracesDiscard_ShouldExecuteDoMethod() {
        // Act
        _benchmark.IsCurlyBracesDiscard();

        // Assert
        // No assertions needed, the method should execute without any exceptions
    }
#endif
}