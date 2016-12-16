using static Logic.BitMixer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{

    [TestClass]
    public class BitMixerTests
    {
        #region BadTests
        [TestMethod]
        public void InsertationByBitArray_Test()
        {
            int result = InsertionByBitArray(8, 15, 0, 0);

            Assert.AreEqual(result, 9);

            result = InsertionByBitArray(0, -15, 30, 30);

            Assert.AreEqual(result, 1073741824);

            result = InsertionByBitArray(0, 15, 0, 30);

            Assert.AreEqual(result, 15);

            result = InsertionByBitArray(15, -15, 4, 4);

            Assert.AreEqual(result, 31);

            result = InsertionByBitArray(15, int.MaxValue, 3, 5);

            Assert.AreEqual(result, 63);

        }

        [TestMethod]
        public void InsertationByChars_Test()
        {
            int result = InsertionByChars(8, 15, 0, 0);

            Assert.AreEqual(result, 9);

            result = InsertionByChars(0, -15, 30, 30);

            Assert.AreEqual(result, 1073741824);

            result = InsertionByChars(0, 15, 0, 30);

            Assert.AreEqual(result, 15);

            result = InsertionByChars(15, -15, 4, 4);

            Assert.AreEqual(result, 31);

            result = InsertionByChars(15, int.MaxValue, 3, 5);

            Assert.AreEqual(result, 63);
        }

#endregion
    }
}
