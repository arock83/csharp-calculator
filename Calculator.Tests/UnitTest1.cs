using System;
using Xunit;
using System.Linq;


namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoIntegers()
        {
            // Given this input to the method
            int sum = _calculator.Add(54, 29);

            // We are asserting that the output should be this
            Assert.Equal(sum, 83);
        }
        [Fact]
        public void SubtractTwoIntegers()
        {
            int difference = _calculator.Subtract(43, 13);

            Assert.Equal(difference, 30);
        }

        [Fact]
        public void MultiplyTwoIntegers()
        {
            int times = _calculator.Multiply(5, 4);

            Assert.Equal(times, 20);
        }

        [Fact]
        public void DivideTwoIntergers()
        {
            double division = _calculator.Divide(44, 11);

            Assert.Equal(division, 4);
        }
    }
}