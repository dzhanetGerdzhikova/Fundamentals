using System;

namespace Multiply_Evens_by_Odds
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            number = Math.Abs(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        private static decimal GetSumOfEvenDigits(decimal num)
        {
            decimal result = 0;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                if (decimal.Parse(num.ToString()[i].ToString()) % 2 == 0)
                {
                    result += decimal.Parse(num.ToString()[i].ToString());
                }
            }

            return result;
        }

        private static decimal GetSumOfOddDigits(decimal num)
        {
            decimal result = 0;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if (decimal.Parse(num.ToString()[i].ToString()) % 2 == 1)
                {
                    result += decimal.Parse(num.ToString()[i].ToString());
                }
            }

            return result;
        }

        private static decimal GetMultipleOfEvenAndOdds(decimal number)
        {
            decimal sumOfEven = GetSumOfEvenDigits(number);
            decimal sumOfOdd = GetSumOfOddDigits(number);

            return sumOfEven * sumOfOdd;
        }
    }
}