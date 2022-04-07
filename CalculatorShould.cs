using System;
using Xunit;
using Assignment3Calculator;

namespace Assignment3Calculator.Tests
{
    public class CalculatorShould
    {
        [Fact]
        public void AddTwoValues()
        {
            // Arange
            Calculator sut = new Calculator();
            // Act
            double result = sut.AddValues(5, 5);
            // Assert
            Assert.Equal(10, result);
        }

        [Fact]
        public void SubstractTwoValues()
        {
            // Arange
            Calculator sut = new Calculator();
            // Act
            double result = sut.SubstractValues(10, 5);
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void MultiplyTwoValues()
        {
            // Arange
            Calculator sut = new Calculator();
            // Act
            double result = sut.MultiplyValues(10, 5);
            // Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void DivideTwoValues()
        {
            // Arange
            Calculator sut = new Calculator();
            // Act
            double result = sut.DivideValues(10, 5);
            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void HandleDivisionWithZero()
        {
            // Arange
            Calculator sut = new Calculator();

            // Act
            double result = sut.DivideValues(5, 0);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
