using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Validation
    {
        public static void CheckNullParam(decimal[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException();
            }
        }

        public static void CheckLengthParams(decimal[] numbers)
        {

            if (numbers.Length < 2)
            {
                throw new ArgumentException();
            }
        }


    }
}
