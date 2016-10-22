using System;
using static Logic.ArrayHelper;
using static Logic.StringHelper;
using static Logic.BitMixer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{
    [TestClass]
    public class ArrayHelper_Test
    {
        [TestMethod]//Split to different tests.
        public void TestArray()
        {
            int result = FindCentralIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });

            Assert.AreEqual(result , 3);

            result = FindCentralIndex(new int[] { 1, 100, 50, -51, 1, 1 });

            Assert.AreEqual(result, 1);

            result = FindCentralIndex(new int[] { 1, 25, 51, -51, 1, 1 });

            Assert.AreEqual(result, -1);

            result = FindCentralIndex(null);// массив 0лей проверить

            Assert.AreEqual(result, -1);

        }


        
    }
    [TestClass]
    public class StringHelper_Test
    {
        [TestMethod]//Split to different tests.
        public void TestOneLine()
        {
            string result = Solute("abdcff" + "aadde");

            Assert.AreEqual(result, "abcdef");

        }



    }
    [TestClass]
    public class BitMixer_Test
    {
        [TestMethod]//Split to different tests.
        public void Mix()
        {
            int result = Insertation(8, 15, 0, 0);

            Assert.AreEqual(result, 9);

        }



    }
}
