using System;

namespace Factorial_Division
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorialDivision(num1, num2):f2}");
        }

        private static double FactorialDivision(long num1, long num2)
        {
            long firstResult = 1;
            long secondResult = 1;
            for (long i = 1; i <= num1; i++)
            {
                firstResult *= i;
            }

            for (long i = 1; i <= num2; i++)
            {
                secondResult *= i;
            }
            double result = firstResult / (secondResult * 1.00);
            return result;
        }
    }
}