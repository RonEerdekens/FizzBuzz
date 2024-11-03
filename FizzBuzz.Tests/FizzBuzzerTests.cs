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
            [TestCase(27)]
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
        [TestFixture]
        public class WhenNumberDivisibleBy5
        {
            [TestCase(5)]
            [TestCase(10)]
            [TestCase(20)]
            public void ShouldReturnBuzz(int number)
            {
                // Arrange
                var sut = new FizzBuzzer();
                // Act
                var actual = sut.Start(number);
                // Assert
                Assert.That(actual, Is.EqualTo("Buzz"));
            }
        }
        [TestFixture]
        public class  WhenNumberDivisibleBy3Or5
        {
            [TestCase(15)]
            [TestCase(30)]
            [TestCase(45)]
            public void ShouldReturnFizzBuzz(int number)
            {
                // Arrange
                var sut = new FizzBuzzer();
                // Act
                var actual = sut.Start(number);
                // Assert
                Assert.That(actual, Is.EqualTo("FizzBuzz"));
            }
        }
    }
}
