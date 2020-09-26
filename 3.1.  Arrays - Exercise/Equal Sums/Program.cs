using System;
using System.Linq;

namespace Equal_Sums
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sumRight = 0;
            int sumLeft = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                index = i;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += numbers[j];
                }
                for (int k = numbers.Length - 1; k > i; k--)
                {
                    sumRight += numbers[k];
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }
                sumRight = 0;
                sumLeft = 0;
            }
            if (index == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}