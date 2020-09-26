using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsWithSynonyms = new Dictionary<string, List<string>>();

            for (int i = 0; i < countInput; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                List<string> synonyms = new List<string>();

                if (!wordsWithSynonyms.ContainsKey(word))
                {
                    synonyms.Add(synonym);
                    wordsWithSynonyms.Add(word, synonyms);
                }
                else
                {
                    wordsWithSynonyms[word].Add(synonym);
                }
            }

            foreach (var cell in wordsWithSynonyms)
            {
                Console.WriteLine($"{cell.Key} - {string.Join(", ", cell.Value)} ");
            }
        }

        private static string[] ToList()
        {
            throw new NotImplementedException();
        }
    }
}