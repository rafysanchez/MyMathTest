using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;
namespace MyProjectTest
{
    [TestClass]
    public class BasicOperationTest
    {
        [TestMethod]
        public void TestAdd()
        {
            int expectedResult = 4;
            BasicOperations basic = new MyPrograms.BasicOperations();

            int actualResult = basic.Add(2, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMul()
        {
            int expectedResult = 4;
            BasicOperations basic = new MyPrograms.BasicOperations();

            int actualResult = basic.Mul(2, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestSub()
        {
            int expectedResult = 0;
            BasicOperations basic = new MyPrograms.BasicOperations();

            int actualResult = basic.Sub(2, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestDiv()
        {
            int expectedResult = 1;
            BasicOperations basic = new MyPrograms.BasicOperations();

            int actualResult = basic.Div(2, 2);

            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
