using Calculator;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Addition()
        {
            //Arrange
            decimal firstNum = 5;
            decimal secondNum = 6;

            //Act

            (decimal, decimal, string, decimal) values = Calculator.Calculator.Addition(firstNum, secondNum);

            //Assert
            Assert.Equal(values.Item4, firstNum + secondNum);
        }


        [Fact]
        public void Subtraction()
        {
            //Arrange
            decimal firstNum = 5;
            decimal secondNum = 6;

            //Act

            (decimal, decimal, string, decimal) values = Calculator.Calculator.Subtraction(firstNum, secondNum);

            //Assert
            Assert.Equal(values.Item4, firstNum - secondNum);
        }

        [Fact]
        public void Multiplication()
        {
            //Arrange
            decimal firstNum = 5;
            decimal secondNum = 6;

            //Act

            (decimal, decimal, string, decimal) values = Calculator.Calculator.Multiplication(firstNum, secondNum);

            //Assert
            Assert.Equal(values.Item4, firstNum * secondNum);
        }

        [Fact]
        public void Division()
        {
            //Arrange
            decimal firstNum = 5;
            decimal secondNum = 6;

            //Act

            (decimal, decimal, string, decimal) values = Calculator.Calculator.Division(firstNum, secondNum);

            //Assert
            Assert.Equal(values.Item4, firstNum / secondNum);
        }

    }
}