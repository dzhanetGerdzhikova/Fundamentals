using System;

namespace Special_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= num; currentNumber++)
            {
                int sum = 0;
                for (int symbol = 0; symbol <= currentNumber.ToString().Length - 1; symbol++)
                {
                    sum += int.Parse(currentNumber.ToString()[symbol].ToString());
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{currentNumber} -> True");
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> False");
                }
            }
        }
    }
}