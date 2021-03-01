using Xunit;
using FluentAssertions;

namespace CalculatorWithPriority.Test
{
    public class SubtractionTest
    {
        [Fact]
        public void Subtraction8and8equal0()
        {
            var answer = new Subtraction().Calc(8, 8);
            answer.Should().Be(0);
        }
    }
}
