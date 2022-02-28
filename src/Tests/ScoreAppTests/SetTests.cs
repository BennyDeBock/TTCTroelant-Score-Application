using System;
using Domain.ScoreApp;
using Xunit;

namespace Tests.ScoreAppTests
{
    public class SetTests
    {
        [Theory]
        [InlineData(5, 7)]
        [InlineData(0, 17)]
        [InlineData(11, 12)]
        [InlineData(7, 5)]
        [InlineData(17, 0)]
        [InlineData(12, 11)]
        public void Set_Validation_Fails(uint point1, uint point2)
        {
            Set testSet = new(point1, point2);

            Assert.False(
                testSet.ValidateSet()
            );
        }

        [Theory]
        [InlineData(11, 7)]
        [InlineData(7, 11)]
        [InlineData(9, 11)]
        [InlineData(11, 9)]
        [InlineData(11, 13)]
        [InlineData(13, 11)]
        public void Set_Validation_Passes(uint point1, uint point2)
        {
            Set testSet = new(point1, point2);

            Assert.True(
                testSet.ValidateSet()
            );
        }
    }
}
