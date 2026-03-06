using MonApi.Services;

namespace MonApi.Test.Services
{
    public class MathServiceTest
    {
        [Fact]
        public void Addition_ShouldReturnSumOfIntegerReceive_BasicExample()
        {
            // Arrange
            MathService mathService = new MathService();
            int nb1 = 11;
            int nb2 = 10;
            int expected = 21;

            // Act
            int actual = mathService.Addition(nb1, nb2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-11, -10, -21)]
        [InlineData(-1, 0, -1)]
        [InlineData(-11, 10, -1)]
        public void Addition_ShouldReturnSumOfNegativeIntegerReceive_BasicExample(int nb1, int nb2, int expected)
        {
            // Arrange
            MathService mathService = new MathService();

            // Act
            int actual = mathService.Addition(nb1, nb2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
