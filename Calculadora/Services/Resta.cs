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

            Validation.CheckNullParam(numbers);
            Validation.CheckLengthParams(numbers);

            decimal resta = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                resta -= numbers[i];
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
