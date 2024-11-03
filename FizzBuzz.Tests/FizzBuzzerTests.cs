using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [TestFixture]
        public class WhenNumberDivisibleBy3
        {
            [TestCase(3)]
            [TestCase(21)]
            public void ShouldReturnFizz(int number)
            {
                // Arrange
                var sut = new FizzBuzzer();
                // Act
                var actual = sut.Start(number);
                // Assert
                Assert.That(actual, Is.EqualTo("Fizz"));
            }
        }
    }
}
