using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        // Tests de suma
        [TestMethod]
        public void TestSum()
        {
            decimal[] sum = {1.5M, 1.5M };
            Assert.AreEqual(3M, Suma.Sum(sum)); // 3 parametro es la precision 
            }
       
        [TestMethod]
        public void TestSumNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Suma.Sum(null));
        }

        [TestMethod]
        public void TestSumAlmostTwoItems()
        {
            decimal[] sum = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Suma.Sum(sum));
        }


        [TestMethod]
        public void TestPositiveSum()
        {
            decimal[] sum = { 10.5M, 1M };
            Assert.AreEqual(11.5M, Suma.PositiveSum(sum));
        }

        [TestMethod]
        public void TestPositiveSumNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Suma.PositiveSum(null));
        }


        [TestMethod]
        public void TestPositiveSumAlmostTwoItems()
        {
            decimal[] sum = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Suma.PositiveSum(sum));
        }

        [TestMethod]
        public void TestPositiveSumNumbers()
        {
            decimal[] sum = { 1.5M, -7M };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Suma.PositiveSum(sum));
        }


        [TestMethod]
        public void TestNegativeSum()
        {
            decimal[] sum = { -5.4M, -1M };
            Assert.AreEqual(-6.4M, Suma.NegativeSum(sum));
        }

        [TestMethod]
        public void TestNegativeSumNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => Suma.NegativeSum(null));
        }


        [TestMethod]
        public void TestNegativeSumAlmostTwoItems()
        {
            decimal[] sum = { 1.5M };
            Assert.ThrowsException<ArgumentException>(() => Suma.NegativeSum(sum));
        }

        [TestMethod]
        public void TestNegativeSumNumbers()
        {
            decimal[] sum = { 1.5M, -7M };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Suma.NegativeSum(sum));
        }

        /*
         * 
         * 
         * 
       [TestMethod]
       public void TestDivision()
       {
           // resultado y resto en var resultado
       }*/



    }
}
