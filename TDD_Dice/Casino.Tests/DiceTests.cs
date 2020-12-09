using FluentAssertions;
using Xunit;

namespace Casino.Tests
{
    public class DiceTests
    {
        [Fact]
        public void Dice_is_rollable()
        {
            var dice = new Dice();

            dice.Roll();

            dice.First.Should().BeInRange(1, 6);
            dice.Second.Should().BeInRange(1, 6);
        }

        [Fact]
        public void Dice_to_string()
        {
            var dice = new Dice();

            dice.ToString().Should().Be($"{dice.First}-{dice.Second}");
        }
    }
}
