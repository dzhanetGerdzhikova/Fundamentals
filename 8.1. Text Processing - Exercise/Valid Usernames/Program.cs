using System;
using System.Collections.Generic;

namespace Valid_Usernames
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            bool isValid = true;
            List<string> validNames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!(IsCorrectLenght(input[i]) && IsCorrectSymbols(input[i])))
                {
                    isValid = false;
                    continue;
                }
                validNames.Add(input[i]);
            }
            foreach (var name in validNames)
            {
                Console.WriteLine(name);
            }
        }

        private static bool IsCorrectLenght(string input)
        {
            if (!(input.Length >= 3 && input.Length <= 16))
            {
                return false;
            }
            return true;
        }

        private static bool IsCorrectSymbols(string word)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (!(word[j] >= '0' && word[j] <= '9' || word[j] >= 'a' && word[j] <= 'z' || word[j] >= 'A' && word[j] <= 'Z' || word[j] == '-' || word[j] == '_'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}