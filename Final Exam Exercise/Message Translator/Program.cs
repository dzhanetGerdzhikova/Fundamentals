using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, @"!(?<name>[A-Z][a-z]{3,})!:\[(?<massage>[A-Za-z]{8,})\]");

                if (match.Success)
                {
                    string massage = match.Groups["massage"].Value;
                    List<int> numbers = new List<int>();
                    for (int j = 0; j < massage.Length; j++)
                    {
                        numbers.Add((int)massage[j]);
                    }
                    Console.WriteLine($"{match.Groups["name"].Value}: {string.Join(" ", numbers)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}