using Xunit;
using TestExexise1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            double expected = 0;

            // Act
            double actual = Class1.CalcPrice(1);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}