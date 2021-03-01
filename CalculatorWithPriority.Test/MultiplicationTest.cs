using Xunit;
using FluentAssertions;

namespace CalculatorWithPriority.Test
{
    public class MultiplicationTest
    {
        [Fact]
        public void Multiplication8and8equal64()
        {
            var answer = new Multiplication().Calc(8, 8);
            answer.Should().Be(64);
        }
    }
}
