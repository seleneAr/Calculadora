using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora.Test
{
    [TestClass]
    public class RecursividadTest
    {
        [TestMethod]
        public void TestFactorial() {
            var num = Recursividad.Factorial(5);
            Assert.AreEqual(120, num);
        }

        [TestMethod]
        public void TestFactorialFail()
        {
            var num = Recursividad.Factorial(5);
            Assert.AreNotEqual(80, num);
        }

        [TestMethod]
        public void TestFibonacci()
        {
            var num = Recursividad.Fibonacci(7);
            Assert.AreEqual(13, num);
        }


        [TestMethod]
        public void TestFibonacciFail()
        {
            var num = Recursividad.Fibonacci(7);
            Assert.AreNotEqual(20, num);
        }

       

    }
}
