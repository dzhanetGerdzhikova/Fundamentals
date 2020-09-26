using System;
using System.Text.RegularExpressions;

namespace Message_Encrypter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, @"(?<tag>[*|@])(?<name>[A-z][a-z]{2,})(\k<tag>):\s\[(?<first>[A-Za-z])\]\|\[(?<second>[A-Z-a-z])\]\|\[(?<third>[A-Za-z])\]\|$");
                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["name"].Value}: {(int)char.Parse(match.Groups["first"].Value)} {(int)char.Parse(match.Groups["second"].Value)} {(int)char.Parse(match.Groups["third"].Value)}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}