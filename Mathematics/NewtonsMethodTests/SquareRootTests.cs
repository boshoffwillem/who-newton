using System;
using Xunit;
using Xunit.Abstractions;

namespace NewtonsMethodTests
{
    public class SquareRootTests
    {
        private readonly ITestOutputHelper _output;

        public SquareRootTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData(2.0)]
        [InlineData(25.0)]
        [InlineData(227.0)]
        [InlineData(236535.0)]
        [InlineData(2.5)]
        [InlineData(2245.67)]
        public void SquareRoot_CompareWithSystemSqrt(double value)
        {
            double expected = Math.Round(Math.Sqrt(value), 15);
            double actual = Math.Round(NewtonsMethod.NewtonsMethod.SquareRoot(value), 15);
            _output.WriteLine($"Expected = {expected}");
            _output.WriteLine($"Actual   = {actual}");
            Assert.Equal(expected, actual);
        }
    }
}
