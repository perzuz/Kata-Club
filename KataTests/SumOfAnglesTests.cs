using AutoFixture.Xunit2;
using FluentAssertions;
using Kata_Club.Katas.SumOfAngles;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KataTests
{
    public class SumOfAnglesTests
    {
        [Theory, AutoData]
        public void RandomTest(int numberOfAngles)
        {
            var actual = SumOfAngles.Angle(numberOfAngles);
            actual.Should().Be((numberOfAngles - 2) * 180);
        }
    }
}
