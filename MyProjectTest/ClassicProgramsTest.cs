using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyPrograms;

namespace MyProjectTest
{
    [TestClass]
    public class ClassicProgramsTest
    {
        [TestMethod]
        public void TestIsPrimeTrue()
        {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = true;
            bool actualResult = classicPrograms.IsPrime(2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsPrimeFalse()
        {
            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = false;
            bool actualResult = classicPrograms.IsPrime(12);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestIsEven()
        {

            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = true;
            bool actualResult = classicPrograms.IsEven(2);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestIsOdd()
        {

            ClassicPrograms classicPrograms = new ClassicPrograms();
            bool expectedResult = true;
            bool actualResult = classicPrograms.IsOdd(5);

            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
