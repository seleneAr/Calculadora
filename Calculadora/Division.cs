using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Division
    {

        /// <summary>
        /// Division de numeros positivos
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static decimal PositiveDiv(decimal num1, decimal num2)
        {
            if(num1 < 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }

            return num1 / num2;
        }

        /// <summary>
        /// Division de dos numeros. Devuelve resultado de la operación y resto
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static string DivWithRest(decimal num1, decimal num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return $"{  Decimal.Round(num1 / num2, 3)} - {num1 % num2}";
        }

    
        
    }
}
