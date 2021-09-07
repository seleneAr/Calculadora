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

        // Tests de resta

        [TestMethod]
        public void TestSubtraction()
        {
            decimal[] sub = { 5M, 1.5M };
            Assert.AreEqual(3.5M, Resta.Subtraction(sub)); // 3 parametro es la precision 
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

        // Tests multiplicacion

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



        // Test Division
        [TestMethod]
        public void TestPositiveDiv()
        {
            Assert.AreEqual(2, Division.PositiveDiv(4M, 2M));
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
