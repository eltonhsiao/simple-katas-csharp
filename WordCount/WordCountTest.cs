using System;
using NUnit.Framework;

namespace WordCount
{
    public class WordCountTest
    {
        [Test]
        public void NoWordGiven()
        {
            String input = null;
            String expected = "";

            Assert.AreEqual(expected, WordCount.CountWord(input));
        }
    }
}
