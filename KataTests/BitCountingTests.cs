using AutoFixture;
using AutoFixture.Xunit2;
using FluentAssertions;
using Kata_Club.Katas.BitCounting;
using System;
using System.Linq;
using Xunit;

namespace KataTests
{
    public class BitCountingTests
    {
        [Theory, AutoData]
        public void RandomNumberTest(Generator<int> generator)
        {
            // Arrange
            var bitCounter = new BitCounter();
            var randomNumber = generator.Where(x => x >= 0 && x <= 10).First();
            var expected = Convert.ToString(randomNumber, 2).Count(x => x == '1');

            // Act 
            var actual = bitCounter.CountBits(randomNumber);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
