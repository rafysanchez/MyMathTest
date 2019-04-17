using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;


namespace MyProjectTest
{
    /// <summary>
    /// Descrição resumida para TDDProgramTest
    /// </summary>
    [TestClass]
    public class TDDProgramTest
    {
  
        [TestMethod]
        public void TestSMallest()
        {
            MyPrograms.TTDPrograms _TDDProgramTest = new TTDPrograms();
            int expectedResult = 1;
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int actualResult = _TDDProgramTest.Smallest(arr);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSMallestFalse()
        {
            MyPrograms.TTDPrograms _TDDProgramTest = new TTDPrograms();
            int expectedResult = 7;
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int actualResult = _TDDProgramTest.Smallest(arr);
            Assert.AreNotEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSMallestFalseOne()
        {
            MyPrograms.TTDPrograms _TDDProgramTest = new TTDPrograms();
            int expectedResult = 7;
            int[] arr = {  4 };
            int actualResult = _TDDProgramTest.Smallest(arr);
            Assert.AreNotEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestPowerTrue()
        {
            MyPrograms.TTDPrograms _TDDProgramTest = new TTDPrograms();
            double expectedResult = 8;
            double expectedValue = _TDDProgramTest.Power(2, 3);
            Assert.AreEqual(expectedResult, expectedValue);
        }

        [TestMethod]
        public void TestPowerTrueFalse()
        {
            MyPrograms.TTDPrograms _TDDProgramTest = new TTDPrograms();
            double expectedResult = 9;
            double expectedValue = _TDDProgramTest.Power(2, 3);
            Assert.AreNotEqual(expectedResult, expectedValue);

        }

        [TestMethod]
        public void TestFizzBuzz()
        {
            MyPrograms.TTDPrograms _TDDProgramTest = new TTDPrograms();
            string expectedResult = "Fizz";
            string expectedValue = _TDDProgramTest.GetValueFizzBuzz(12);
            Assert.AreEqual(expectedResult, expectedValue);

        }


    }
}
