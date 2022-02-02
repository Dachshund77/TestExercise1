using Xunit;
using TestExexise1;
using System.Collections.Generic;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [MemberData(nameof(data))]
        public void TestPricingGivenKm(double km, double expected)
        {
            // Arrange
            // Act
            double actual = Class1.CalcPrice(km);

            // Assert
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> data => // consder roubding
            new List<object[]>
            {
                new object[]{-1, 0}, // Defensive programming, probably should throw exception
                new object[]{0, 2500}, // Extreme value, inital >100     
                new object[]{0.5, 2500},// Rounding down
                new object[]{9, 2590},
                new object[]{99, 3490},
                new object[]{99.5, 3490}, // Rounding down
                new object[]{100, 3498}, // Extreme value,  100-500 
                new object[]{500, 6698},
                new object[]{500.5, 6698},// Rounding down
                new object[]{501, 6704}, // Extreme value,  <500 
                new object[]{501.5, 6704}, // Rounding down
                new object[]{601, 7304},
            };
    }
}