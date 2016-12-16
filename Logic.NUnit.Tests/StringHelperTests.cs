using System;
using NUnit.Framework;
using static Logic.StringHelper;

namespace ArrayHelper.NUnit.Tests
{
    [TestFixture]
    public class StringHelperTests
    {
        [TestCase("abdcff", "aadde", "abcdef")]
        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz")]
        public void Longest_TwoStrings_OrderedStringWithoutDuplications(string str1, string str2, string expected)
        {
            //AAA Arrange in SetUP
            //Act
            var result = Longest(str1, str2);
            //Assert 
            Assert.AreEqual(expected, result);
        }


        [TestCase(null, null)]
        [TestCase("asd", null)]
        [TestCase(null, "asd")]
        public void Longest_Nulls_ArgNullException(string str1, string str2)
        {
            Assert.That(() => Longest(str1, str2), Throws.TypeOf<ArgumentNullException>());
        }
        
        [TestCase("asd12", "as12d")]
        [TestCase("asd", "as12d")]
        [TestCase("asd12", "as")]
        public void Longest_Nulls_ArgException(string str1, string str2)
        {
            Assert.That(() => Longest(str1, str2), Throws.TypeOf<ArgumentException>());
        }
    }
}

#region FixtureSource

/*
[TestFixtureSource("FixtureArgs")]
class BitMixerTests
{
    static int[][] FixtureArgs =
    {
        new int[] {8, 15, 0, 0},
        new int[] {0, -15, 30, 30}
    };
}
*/

#endregion