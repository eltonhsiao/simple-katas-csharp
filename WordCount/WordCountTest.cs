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

        [Test]
        public void TwoDifferentWordGiven()
        {
            String input = "olly in";
            String expected = "olly: 1 in: 1 ";

            Assert.AreEqual(expected, WordCount.CountWord(input));
        }

        [Test]
        public void TwoSameWordGiven()
        {
            String input = "olly olly";
            String expected = "olly: 2 ";

            Assert.AreEqual(expected, WordCount.CountWord(input));
        }
    }
}
