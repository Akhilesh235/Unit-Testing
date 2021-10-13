using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculator calc;
        [TestInitialize]
        public void TestInitialize()
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            int result = calc.Add(10, 15);
            Assert.AreEqual(result, 25);

        }

        [TestMethod]
        public void TestSubtraction()
        {
            int result = calc.Sub(10, 15);
            Assert.AreEqual(result, -5);

        } 

        [TestCleanup]
        public void Cleanup()
        {
            calc = null;
        }
    }
}
