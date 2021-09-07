using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Multiplicacion
    {
        /// <summary>
        /// Multiplicacion de numeros
        /// </summary>
        /// <returns></returns>
        public static decimal Multiply(decimal[] numbers)
        {
            Validation.CheckNullParam(numbers);
            Validation.CheckLengthParams(numbers);

            decimal multiplication = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                multiplication *= numbers[i];
            }

            return multiplication;
        }

        
        /// <summary>
        /// Multiplicacion de numeros pares
        /// </summary>
        /// <returns></returns>
        public static decimal EvenNumMultiply(decimal[] numbers)
        {
            Validation.CheckNullParam(numbers);
            Validation.CheckLengthParams(numbers);

            decimal multiplication = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0) {
                    throw new ArgumentOutOfRangeException();
                }
                multiplication *= numbers[i];
            }
            return multiplication;
        }

       

        /// <summary>
        /// Multiplicacion donde el resultado no puede ser 0.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static decimal NotZeroMultiplication(decimal[] numbers)
        {
            Validation.CheckNullParam(numbers);
            Validation.CheckLengthParams(numbers);

            decimal multiplication = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                multiplication *= numbers[i];
            }
            return multiplication;
        }

    }
}
