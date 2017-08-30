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

        [Test]
        public void OneWordGiven()
        {
            String input = "olly";
            String expected = "olly: 1 ";

            Assert.AreEqual(expected, WordCount.CountWord(input));
        }
    }
}
