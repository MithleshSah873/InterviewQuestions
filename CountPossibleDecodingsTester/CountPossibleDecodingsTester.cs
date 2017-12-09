﻿using CountPossibleDecodingsQuestion;
using NUnit.Framework;

namespace CountPossibleDecodingsTester
{
    [TestFixture]
    public class CountPossibleDecodingsTester
    {
        [TestCase(3, "123", 3)]
        [TestCase(1, "103", 3)]
        [TestCase(0, "675356291270936062618792", 24)]
        [TestCase(4, "23759228973", 11)]
        public void CountPossibleDecodingsTest1(int expected, string inputString, int lengthOfInputString)
        {
            Assert.AreEqual(expected, CountPossibleDecodings.CountAlphabetsDecoded(inputString, lengthOfInputString));
        }
    }
}
