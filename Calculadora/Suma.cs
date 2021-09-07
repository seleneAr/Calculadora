using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Suma
    {
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
    }
}
