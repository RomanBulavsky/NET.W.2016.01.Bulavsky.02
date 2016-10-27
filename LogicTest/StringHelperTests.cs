using System;
using static Logic.StringHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTest
{ 
    [TestClass]
    public class StringHelperTests
    {
        private string a, b, result;

        #region BadTests

        
           
        [TestMethod]//Split to different tests.
        public void CheatSolution_Test()
        {

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
        public void FilterNSort_TwoStrings_OneSortedStringWithoutDuplicateSymbols()
        {
            

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

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void FilterNSort_NullInString_Exception()
        {
            result = Longest(null, null);
            result = Longest("asd", null);
            result = Longest(null, "asd");
        }

        #endregion

    }
}
