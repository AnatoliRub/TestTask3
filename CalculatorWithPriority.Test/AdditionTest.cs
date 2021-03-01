using Xunit;
using FluentAssertions;

namespace CalculatorWithPriority.Test
{
    public class AdditionTest
    {
        [Fact]
        public void Addition8and8equal16()
        {
            var answer = new Addition().Calc(8, 8);
            answer.Should().Be(16);
        }
    }
}
