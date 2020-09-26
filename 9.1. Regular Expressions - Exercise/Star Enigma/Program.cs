using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            List<string> attack = new List<string>();
            List<string> destroyed = new List<string>();

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                StringBuilder newInput = new StringBuilder();
                int countStarLetters = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 's' || input[j] == 't' || input[j] == 'a' || input[j] == 'r' || input[j] == 'S' || input[j] == 'T' || input[j] == 'A' || input[j] == 'R')
                    {
                        countStarLetters++;
                    }
                }

                for (int k = 0; k < input.Length; k++)
                {
                    newInput.Append((char)((int)input[k] - countStarLetters));
                }

                Match match = Regex.Match(newInput.ToString(), @"@(?<planetName>[A-Za-z]+)[^@,\-!:>]*?:(?<population>[0-9]+)[^@,\-!:>]*?!(?<attackType>[A|D])![^@,\-!:>]*?->(?<soldierCount>[0-9]+)");
                if (match.Success)
                {
                    if (match.Groups["attackType"].Value == "A")
                    {
                        attack.Add(match.Groups["planetName"].Value);
                    }
                    else if (match.Groups["attackType"].Value == "D")
                    {
                        destroyed.Add(match.Groups["planetName"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attack.Count}");
            attack = attack.OrderBy(x => x).ToList();
            foreach (var planet in attack)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed = destroyed.OrderBy(x => x).ToList();
            foreach (var planet in destroyed)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}