using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Test
{
    [TestClass]
    public class RestaTest
    {

        [TestMethod]
        public void TestSubtraction()
        {
            decimal[] sub = { 5M, 1.5M };
            Assert.AreEqual(3.5M, Resta.Subtraction(sub));
        }

        [TestMethod]
        public void TestSubtractionNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Resta.Subtraction(null));
        }

        [TestMethod]
        public void TestSubtractionAlmostTwoItems()
        {
            decimal[] sub = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Resta.Subtraction(sub));
        }

        [TestMethod]
        public void TestSubtractionTwoNum()
        {
            Assert.AreEqual(2.5M, Resta.SubtractionTwoNumbers(5.5M, 3M));
        }

        [TestMethod]
        public void TestSubtractionTwoNumfirstBigger()
        {
            Assert.ThrowsException<ArgumentException>(() => Resta.SubtractionTwoNumbers(1M, 3.5M));

        }
    }
}
