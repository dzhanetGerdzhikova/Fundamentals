using System;

namespace Refactor_Special_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int totalNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= totalNumber; currentNumber++)
            {
                int sum = 0;
                bool isSpecial = false;
                int newNumber = currentNumber;
                while (newNumber > 0)
                {
                    sum += newNumber % 10;
                    newNumber = newNumber / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{currentNumber} -> {isSpecial}");
            }
        }
    }
}