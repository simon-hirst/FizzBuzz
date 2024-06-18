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
    }
}