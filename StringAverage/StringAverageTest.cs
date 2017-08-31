using System;
using NUnit.Framework;

namespace StringAverage
{
    public class StringAverageTest
    {
        [Test]
        public void NoNumberGiven()
        {
            String input = null;
            String expected = "n/a";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }
    }
}
