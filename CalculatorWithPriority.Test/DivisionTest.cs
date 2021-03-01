using Xunit;
using FluentAssertions;

namespace CalculatorWithPriority.Test
{
    public class DivisionTest
    {
        [Fact]
        public void Division8and8equal1()
        {
            var answer = new Division().Calc(8, 8);
            answer.Should().Be(1);
        }
    }
}
