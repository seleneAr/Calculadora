using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Suma
    {
    /// <summary>
    /// Suma de cualquier tipo de numero
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
        public static decimal Sum(decimal[] numbers)
        {

            if(numbers == null)
            {
                throw new ArgumentNullException();
            }

            if(numbers.Length < 2)
            {
                throw new ArgumentException();
            }

            decimal suma = 0;

            foreach(var number in numbers)
            {
                suma += number;
            }

            return suma;
        }


        /// <summary>
        /// Suma de numeros positivos
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static decimal PositiveSum(decimal[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            if (numbers.Length < 2)
            {
                throw new ArgumentException();
            }

            decimal suma = 0;

            foreach (var number in numbers)
            {
 
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                suma += number;

            }
            return suma;

        }


        /// <summary>
        /// suma de numeros negativos
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static decimal NegativeSum(decimal[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }

            if (numbers.Length < 2)
            {
                throw new ArgumentException();
            }

            decimal suma = 0;

            foreach (var number in numbers)
            {

                if (number > 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                suma += number;

            }
            return suma;
        }

    }
}
