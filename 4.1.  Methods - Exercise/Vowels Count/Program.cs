using System;

namespace Vowels_Count
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            VowelsCount(input);
        }

        private static void VowelsCount(string input)
        {
            string lowerInput = input.ToLower();
            int counter = 0;
            for (int i = 0; i < lowerInput.Length; i++)
            {
                if (lowerInput[i] == 'a')
                {
                    counter++;
                }
                else if (lowerInput[i] == 'e')
                {
                    counter++;
                }
                else if (lowerInput[i] == 'o')
                {
                    counter++;
                }
                else if (lowerInput[i] == 'u')
                {
                    counter++;
                }
                else if (lowerInput[i] == 'i')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}