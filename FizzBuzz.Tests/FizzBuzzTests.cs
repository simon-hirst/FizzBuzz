using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void FizzRule_ReturnsFizzForMultiplesOfThree()
        {
            var rule = new FizzRule();
            Assert.IsTrue(rule.IsMatch(3));
            Assert.AreEqual("Fizz", rule.GetOutput(3));
        }

        [Test]
        public void BuzzRule_ReturnsBuzzForMultiplesOfFive()
        {
            var rule = new BuzzRule();
            Assert.IsTrue(rule.IsMatch(5));
            Assert.AreEqual("Buzz", rule.GetOutput(5));
        }
    }
}