using System;
using NUnit.Framework;
using static Logic.ArrayHelper;

namespace ArrayHelper.NUnit.Tests
{
    [TestFixture]
    public class ArrayHelper_Test
    {
        
        #region BadWay&SetUpExample

        private int[] centricArray;
        private int[] tailArray;
        private int[] badArray;
        private int[] notAnArray;

        [SetUp]
        protected void SetUp()
        {
            centricArray = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            tailArray = new int[] { 1, 100, 50, -51, 1, 1 };
            badArray = new int[] { 1, 25, 51, -51, 1, 1 };
            notAnArray = null;
        }


        [Test]
        public void FindCoreIndex_CentericArray_CentralIndex()
        {
            //AAA Arrange in SetUP
            //Act
            var result = FindCoreIndex(centricArray);
            //Assert 
            Assert.AreEqual(3, result);
        }

        [Test]
        public void FindCoreIndex_TailArray_FirstIndex()
        {
            //AAA Arrange in SetUP
            //Act
            var result = FindCoreIndex(tailArray);
            //Assert 
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void FindCoreIndex_BadArray_Null()
        {
            //AAA Arrange in SetUP
            //Act
            var result = FindCoreIndex(badArray);
            //Assert 
            Assert.AreEqual(null, result);
        }

        #endregion

        /// <summary>
        /// A convenient way to test different input sequences. 
        /// </summary>

        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, 1)]
        [TestCase(new int[] { 1, 25, 51, -51, 1, 1 }, null)]
        public void FindCoreIndex_Array_CoreIndex(int[] inputArray, int? expected)
        {
            //AAA
            //Act
            var result = FindCoreIndex(inputArray);
            //Assert 
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Method for testing an exceptions.
        /// </summary>
        [Test]
        public void FindCoreIndex_Null_NullRefException()
        {
            
            Assert.That(() => FindCoreIndex(notAnArray), Throws.TypeOf<NullReferenceException>());

        }


    }



}
