using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Recursividad
    {
        public static int Factorial(int n)
        {
            if (n > 1)
            {
                return n *= Factorial(n - 1);

            }
            if (n == 1)
            {
                return 1;
            }
            return n;
        }

        public static int Fibonacci(int n)
        {
            // Fibonacci es la sucesion de : numero - 1 + numero -2
            //0 = 0, 1 = 1

            if (n == 0)
            {
                return 0;

            }
            else if (n == 1)
            {

                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);


            }
        }

        public string Name = "paco";
    
       
        //public static string ReverseString(string name)
        //{
        //    if(name.Length <= 1)
        //    {
        //        return name;
        //    }
        //    char LastChar = name[name.Length + 1];
        //    string RestCahin = name.Substring(1);
        //    string NewChain = "";
        //}

        //public static string ReverseString(string name, int index)
        //{
        //    char[] ArrayName = name.ToCharArray();

        public static string HateRcursivity()
        {
            return "Odio la recursividad";
        }



        }
    }
}
