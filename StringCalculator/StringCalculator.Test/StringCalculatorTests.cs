using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using StringCalculator.Core;

namespace StringCalculator.Test
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase("1,2,3", Result = 6)]
        [TestCase("2,4,9,5", Result = 20)]
        [TestCase("18", Result = 18)]
        public double Calculator_When_CommaSeparated_Then_CorrectTotalReturned(string input)
        {
            // Arrange
            double sum;
            Calculator c = new Calculator();
            string[] numbers = input.Split(',');

            // Act
            sum = c.Sum(numbers);

            // Assert
            return sum;
        }
    }
}
