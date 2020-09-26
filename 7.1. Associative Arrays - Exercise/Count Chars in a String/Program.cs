using System;
using System.Collections.Generic;

namespace Count_Chars_in_a_String
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            int value = 1;
            foreach (var word in input)
            {
                for (int i = 0; i <= word.Length - 1; i++)
                {
                    if (!countOfChars.ContainsKey(word[i]))
                    {
                        countOfChars.Add(word[i], value);
                    }
                    else
                    {
                        countOfChars[word[i]]++;
                    }
                }
            }

            foreach (var cell in countOfChars)
            {
                Console.WriteLine($"{cell.Key} -> {cell.Value}");
            }
        }
    }
}