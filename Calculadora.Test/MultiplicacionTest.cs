using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Test
{
    [TestClass]
    public class MultiplicacionTest
    {

        [TestMethod]
        public void TestMultiply()
        {
            decimal[] multi = { 2M, 5.5M };
            Assert.AreEqual(11M, Multiplicacion.Multiply(multi));
        }

        [TestMethod]
        public void TestMultiplyNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Multiplicacion.Multiply(null));
        }

        [TestMethod]
        public void TestMultiplyAlmostTwoItems()
        {
            decimal[] multi = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Multiplicacion.Multiply(multi));
        }

        [TestMethod]
        public void TestEvenMultiply()
        {
            decimal[] multi = { 2M, 4M };
            Assert.AreEqual(8M, Multiplicacion.Multiply(multi));
        }

        [TestMethod]
        public void TestEvenMultiplyNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Multiplicacion.EvenNumMultiply(null));
        }

        [TestMethod]
        public void TestEvenMultiplyAlmostTwoItems()
        {
            decimal[] multi = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Multiplicacion.EvenNumMultiply(multi));
        }

        [TestMethod]
        public void TestEvenMultiplyAreEvenNums()
        {
            decimal[] multi = { 2M, 7M };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Multiplicacion.EvenNumMultiply(multi));
        }

        [TestMethod]
        public void TestNotZeroMultiplication()
        {
            decimal[] multi = { 2M, 4M };
            Assert.AreEqual(8M, Multiplicacion.NotZeroMultiplication(multi));
        }

        [TestMethod]
        public void TestMultiplyNotZeroNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Multiplicacion.NotZeroMultiplication(null));
        }

        [TestMethod]
        public void TestMultiplyNotZeroAlmostTwoItems()
        {
            decimal[] multi = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Multiplicacion.NotZeroMultiplication(multi));
        }

        [TestMethod]
        public void TestMultiplyNotZeroNotZeros()
        {
            decimal[] multi = { 2M, 0M };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Multiplicacion.NotZeroMultiplication(multi));
        }

    }
}
