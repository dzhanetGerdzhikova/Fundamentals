using System;
using System.Linq;

namespace Equal_Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbersFirst = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbersSecond = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int counter = 0;
            for (int i = 0; i < numbersFirst.Length; i++)
            {
                if (numbersFirst[i] != numbersSecond[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    counter++;
                    sum += numbersFirst[i];
                }

                if (counter == numbersFirst.Length)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
            }
        }
    }
}