using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        public class CalculatorTest
        {
            [Theory]
            [InlineData(0, 1, 1, 2)]
            [InlineData(0, 0, 0, 0)]
            [InlineData(-1, -1, -1, -3)]
            [InlineData(-2, 1, 1, 0)]

            public void Add_Test(int num1, int num2, int num3, int expected)
            {
                // Arrange
                var c = new Calculator();

                // Act
                var actual = c.Add(num1, num2, num3);

                // Assert
                Assert.Equal(expected, actual);
            }


            [Theory]
            [InlineData(1, 1, 0)]
            [InlineData(1, 0, 1)]
            [InlineData(2, 1, 1)]
            [InlineData(2, 0, 2)]

            public void Subtract_Test(int num1, int num2, int expected)
            {
                // Arrange
                var c = new Calculator();
                // Act
                var result = c.Subtract(num1, num2);
                // Assert
                Assert.Equal(expected, result);
            }

            [Theory]
            [InlineData(2, 2, 4)]
            [InlineData(3, 3, 9)]
            [InlineData(4, 4, 16)]

            public void Multiply_Test(int num1, int num2, int expected)
            {
                //Arrange 
                var c = new Calculator();


                // Act
                var result = c.Multiply(num1, num2);

                // Assert 
                Assert.Equal(expected, result);
            }
            [Theory]
            [InlineData(2, 2, 1)]
            [InlineData(3, 3, 1)]
            [InlineData(4, 4, 1)]

            public void Divide_Test(int num1, int num2, int expected)
            {
                var c = new Calculator();
                var result = (c.Divide(num1, num2));
                Assert.Equal(expected, result);
            }

        }
    }
}
