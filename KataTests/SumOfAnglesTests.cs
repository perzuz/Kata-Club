using AutoFixture.Xunit2;
using FluentAssertions;
using Kata_Club.Katas.SumOfAngles;
using Xunit;

namespace KataTests
{
    public class SumOfAnglesTests
    {
        [Theory, AutoData]
        public void RandomTest(int numberOfAngles)
        {
            // Arrange 
            var sumOfAngles = new SumOfAngles();
            var expected = (numberOfAngles - 2) * 180;

            // Act
            var actual = sumOfAngles.Angle(numberOfAngles);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
