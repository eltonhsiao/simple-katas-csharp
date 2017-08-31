using System;
using NUnit.Framework;

namespace StringAverage
{
    public class StringAverageTest
    {
        [Test]
        public void NoNumber_Given_Should_Return_NA()
        {
            String input = string.Empty;
            String expected = "n/a";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void OneNumber_Zero_Given_Should_Return_Zero()
        {
            String input = "Zero";
            String expected = "Zero";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }
    }
}
