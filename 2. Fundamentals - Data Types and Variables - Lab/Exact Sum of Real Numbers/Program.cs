using System;

namespace Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3 };
            char[] stringArray = { 'H', 'e', 'l', 'l', 'o' };

            int countNumber = int.Parse(Console.ReadLine());
            decimal sumNumber = 0;
            for (int i = 0; i < countNumber; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                sumNumber += currentNumber;
            }
            Console.WriteLine(sumNumber);
        }
    }
}