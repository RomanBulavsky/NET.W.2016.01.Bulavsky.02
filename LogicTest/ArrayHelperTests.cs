using System;
using static Logic.ArrayHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{
    [TestClass]
    public class ArrayHelperTests
    {
        private int? result;
        private int? expected;
        private int[] array;

        [TestMethod]
        public void FindCoreIndex_CentericArray_CentralIndex()
        {
            //AAA
            array = new int[] {1, 2, 3, 4, 3, 2, 1};
            result = FindCoreIndex(array);
            expected = 3;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FindCoreIndex_Array_FirstIndex()
        {
            //AAA
            array = new int[] {1, 100, 50, -51, 1, 1};
            result = FindCoreIndex(array);
            expected = 1;
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void FindCoreIndex_ArrayWithoutCenter_Null()
        {
            //AAA
            array = new int[] {1, 25, 51, -51, 1, 1};
            result = FindCoreIndex(array);
            expected = null;
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FindCoreIndex_Null_NullReferenceException()
        {
            ///AAA
            array = null;
            result = FindCoreIndex(array);
            //expected - NullRefException
            //Assert.AreEqual(result, null);

        }


    }
}
