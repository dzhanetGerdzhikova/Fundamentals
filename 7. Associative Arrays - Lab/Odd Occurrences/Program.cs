using System;
using System.Collections.Generic;
using System.Linq;

namespace Odd_Occurrences
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            Dictionary<string, int> programmingLanguages = new Dictionary<string, int>();

            int value = 0;

            foreach (var word in input)
            {
                string language = word.ToLower();
                if (!programmingLanguages.ContainsKey(language))
                {
                    programmingLanguages.Add(language, value);
                }
                programmingLanguages[language]++;
            }

            foreach (var kvp in programmingLanguages)
            {
                if (kvp.Value % 2 == 1)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}