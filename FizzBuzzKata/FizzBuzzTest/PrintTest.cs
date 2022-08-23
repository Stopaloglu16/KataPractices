using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzzTest
{
    public class PrintTest
    {

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void return_fizz_buzz_fizzbuzz(int value, string rtnValue)
        {

            Assert.AreEqual(rtnValue, FizzBuzzLogic.PrintOption(value));

        }

    }
}
