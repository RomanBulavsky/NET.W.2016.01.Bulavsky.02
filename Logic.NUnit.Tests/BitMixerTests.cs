using System;
using NUnit.Framework;
using static Logic.BitMixer;

namespace ArrayHelper.NUnit.Tests
{
    [TestFixture]
    class BitMixerTests { 
  

        [TestCase(8, 15, 0, 0, 9)]
        [TestCase(0, -15, 30, 30, 1073741824)]
        [TestCase(0, 15, 0, 30, 15)]
        [TestCase(15, -15, 4, 4, 31)]
        [TestCase(15, int.MaxValue, 3, 5, 63)]
        public void InsertationByChars_TwoNumbersWithIndexesOfPositionsChange_ExpectedNumber(int numberA, int numberB, int iPosition, int jPosition, int expectedNumber)
        {
            //AAA Arrange in Args
            //Act
            var result = InsertationByChars(numberA, numberB, iPosition, jPosition);
            //Assert 
            Assert.AreEqual(expectedNumber, result);
        }

    }
}

