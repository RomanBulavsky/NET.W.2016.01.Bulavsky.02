using static Logic.ArrayHelper;
using static Logic.StringHelper;
using static Logic.BitMixer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{
    [TestClass]
    public class ArrayHelper_Test
    {
        [TestMethod]
        public void FindCentralIndex_Test()
        {
            int? result = FindCentralIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            Assert.AreEqual(result , 3);

            result = FindCentralIndex(new int[] { 1, 100, 50, -51, 1, 1 });
            Assert.AreEqual(result, 1);

            result = FindCentralIndex(new int[] { 1, 25, 51, -51, 1, 1 });
            Assert.AreEqual(result, null);

            result = FindCentralIndex(null);
            Assert.AreEqual(result, null);

        }
   
    }
    [TestClass]
    public class StringHelper_Test
    {
        [TestMethod]//Split to different tests.
        public void CheatSolution_Test()
        {
            string a, b, result;

            result = CheatSolution("abdcff", "aadde");
            Assert.AreEqual(result, "abcdef");

            a = "xyaabbbccccdefww";
            b = "xxxxyyyyabklmopq";

            result = CheatSolution(a, b);//-> "abcdefklmopqwxy";
            Assert.AreEqual(result, "abcdefklmopqwxy");

            a = "abcdefghijklmnopqrstuvwxyz";

            result = CheatSolution(a, a);//-> "abcdefghijklmnopqrstuvwxyz
            Assert.AreEqual(result, "abcdefghijklmnopqrstuvwxyz");


        }

        [TestMethod]
        public void FilterNSort_Test()
        {
            string a, b, result;

            result = Longest("abdcff", "aadde");
            Assert.AreEqual(result, "abcdef");

            a = "xyaabbbccccdefww";
            b = "xxxxyyyyabklmopq";

            result = Longest(a, b);//-> "abcdefklmopqwxy";
            Assert.AreEqual(result, "abcdefklmopqwxy");

            a = "abcdefghijklmnopqrstuvwxyz";

            result = Longest(a, a);//-> "abcdefghijklmnopqrstuvwxyz
            Assert.AreEqual(result, "abcdefghijklmnopqrstuvwxyz");
        }



    }
    [TestClass]
    public class BitMixer_Test
    {
        [TestMethod]
        public void InsertationByBitArray_Test()
        {
            int result = InsertationByBitArray(8, 15, 0, 0);

            Assert.AreEqual(result, 9);

            result = InsertationByBitArray(0, -15, 30, 30);

            Assert.AreEqual(result, 1073741824);

            result = InsertationByBitArray(0, 15, 0, 30);

            Assert.AreEqual(result, 15);

            result = InsertationByBitArray(15, -15, 4, 4);

            Assert.AreEqual(result, 31);

            result = InsertationByBitArray(15, int.MaxValue, 3, 5);

            Assert.AreEqual(result, 63);

        }

        [TestMethod]
        public void InsertationByChars_Test()
        {
            int result = InsertationByChars(8, 15, 0, 0);

            Assert.AreEqual(result, 9);

            result = InsertationByChars(0, -15, 30, 30);

            Assert.AreEqual(result, 1073741824);

            result = InsertationByChars(0, 15, 0, 30);

            Assert.AreEqual(result, 15);

            result = InsertationByChars(15, -15, 4, 4);

            Assert.AreEqual(result, 31);

            result = InsertationByChars(15, int.MaxValue, 3, 5);

            Assert.AreEqual(result, 63);




            /*
            Insertion()-> 15
            Insertion()-> 31
            Insertion()->63*/
        }
       



    }
}
