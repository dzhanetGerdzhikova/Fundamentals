using System;

namespace Strong_number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int sum = 1;
            int totalSum = 0;

            for (int symbol = 0; symbol < num.Length; symbol++)
            {
                for (int i = 1; i <= int.Parse(num[symbol].ToString()); i++)
                {
                    sum *= i;
                }

                totalSum += sum;
                sum = 1;
            }

            if (num == totalSum.ToString())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}