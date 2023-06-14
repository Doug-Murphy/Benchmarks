#if !NETFRAMEWORK
using Benchmarks.StringBenchmarks;
using FluentAssertions;

namespace Benchmarks.Tests.Unit.StringBenchmarks {
    public class RangeIndexerVersusSubstringTests {
        private const string TestString = "This is a string.";
        private readonly RangeIndexerVersusSubstring _benchmark = new();

        [Fact]
        public void RangeIndexer_ShouldReturnExpectedSubstring() {
            // Arrange
            var expectedSubstring = TestString[TestString.LastIndexOf(" ")..];

            // Act
            var substring = _benchmark.RangeIndexer();

            // Assert
            substring.Should().Be(expectedSubstring);
        }

        [Fact]
        public void Substring_ShouldReturnExpectedSubstring() {
            // Arrange
            var expectedSubstring = TestString.Substring(TestString.LastIndexOf(" "));

            // Act
            var substring = _benchmark.Substring();

            // Assert
            substring.Should().Be(expectedSubstring);
        }
    }
}
#endif