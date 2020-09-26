using System;

namespace Sum_Digits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int symbol = 0; symbol <= number.ToString().Length - 1; symbol++)
            {
                sum += int.Parse(number.ToString()[symbol].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}