using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [DataTestMethod]
        [DataRow(1, "1")]
        [DataRow(2, "2")]
        [DataRow(3, "Fizz")]
        [DataRow(5, "Buzz")]
        [DataRow(15, "FizzBuzz")]
        [DataRow(46, "46")]
        [DataRow(58, "58")]
        [DataRow(63, "Fizz")]
        [DataRow(80, "Buzz")]
        [DataRow(90, "FizzBuzz")]
        [DataRow(99, "Fizz")]
        [DataRow(100, "Buzz")]
        public void GetTest(int x, string expected)
        {
            var actual = FizzBuzzHelper.Get(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetTest_ShouldThrowArgumentOutOfRangeException()
        {
            var value = -1;

            var actual = FizzBuzzHelper.Get(value);
        }
    }
}
