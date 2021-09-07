using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Resta
    {

        /// <summary>
        /// Resta normal de numeros. Se necesitan minimo 2 numeros para hacer una resta.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static decimal Subtraction(decimal[] numbers)
        {

            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            if (numbers.Length < 2)
            {
                throw new ArgumentException();
            }

            decimal resta = 0;

            foreach (var number in numbers)
            {
                resta -= number;
            }

            return resta;
        }


        /// <summary>
        /// Resta de dos numeros. El primero tiene que ser mayor que el segundo.
        /// </summary>
        public static decimal SubtractionTwoNumbers(decimal num1, decimal num2) {
          
            if(num1 < num2)
            {
                throw new ArgumentException();
            }

            return num1 - num2;
        }



    }
}
