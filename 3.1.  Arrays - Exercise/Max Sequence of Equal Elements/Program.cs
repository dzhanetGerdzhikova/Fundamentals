using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int counter = 0;
            int maxCounter = int.MinValue;
            int num = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentElement = numbers[i];
                int nexElement = numbers[i + 1];

                if (currentElement == nexElement)
                {
                    counter++;

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        num = currentElement;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = 0; i <= maxCounter; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}