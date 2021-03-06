﻿using System;
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
            String input = "zero";
            String expected = "zero";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void OneNumber_Four_Given_Should_Return_Zero()
        {
            String input = "four";
            String expected = "four";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void TwoNumber_OneOne_Given_Should_Return_One()
        {
            String input = "one one";
            String expected = "one";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void TwoNumber_TwoOne_Given_Should_Return_One()
        {
            String input = "two one";
            String expected = "one";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void TwoNumber_TwoZero_Given_Should_Return_One()
        {
            String input = "two zero";
            String expected = "one";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void TwoNumber_FourFive_Given_Should_Return_Four()
        {
            String input = "four five";
            String expected = "four";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void SequenceNumber_Given_Should_Return_Four()
        {
            String input = "zero nine five two";
            String expected = "four";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void OneNumber_Ten_Given_Should_Return_NA()
        {
            String input = "Ten";
            String expected = "n/a";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }

        [Test]
        public void SequenceNumberWithTen_Given_Should_Return_NA()
        {
            String input = "zero nine five ten";
            String expected = "n/a";

            Assert.AreEqual(expected, StringAverage.Average(input));
        }
    }
}
