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
        }

#endregion
    }
}
