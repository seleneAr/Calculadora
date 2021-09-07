using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = { 3, 4, 5 };
            decimal[] EvenNumbers = { 6, 8, 12 };
            decimal[] NegativeNumbers = { -3, -4,-5 };

            Console.WriteLine(Division.DivWithRest(4, 5));
            Console.WriteLine(Division.PositiveDiv(6, 3));
            Console.WriteLine(Suma.PositiveSum(numbers));
            Console.WriteLine(Suma.Sum(numbers));
            Console.WriteLine(Suma.NegativeSum(NegativeNumbers));
            Console.WriteLine(Resta.SubtractionTwoNumbers(12,7));
            Console.WriteLine(Resta.Subtraction(numbers));
            Console.WriteLine(Multiplicacion.EvenNumMultiply(EvenNumbers));
            Console.WriteLine(Multiplicacion.NotZeroMultiplication(numbers));
            
        }

       
    }
}
