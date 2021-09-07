using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Test
{
    [TestClass]
    public class DivisionTest
    {

        [TestMethod]
        public void TestPositiveDiv()
        {
            Assert.AreEqual(2, Division.PositiveDiv(4M, 2M));
        }

        [TestMethod]
        public void TestPositiveDivNumbers()
        {
            Assert.ThrowsException<ArgumentException>(() => Division.PositiveDiv(5M, -3M));
        }

        [TestMethod]
        public void TestDivWithRest()
        {

            Assert.AreEqual($"1,333 - 1", Division.DivWithRest(4M, 3M));
        }


        [TestMethod]
        public void TestDivWithRestNotZeroDivider()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Division.DivWithRest(5M, 0M));
        }

    }
}
