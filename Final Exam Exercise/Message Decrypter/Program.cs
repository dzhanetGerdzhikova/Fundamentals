using System;
using System.Text.RegularExpressions;

namespace Message_Decrypter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, @"^(?<tag>[$|%])(?<name>[A-Z][a-z]{2,})(\k<tag>):\s\[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<third>[0-9]+)\]\|$");
                if (match.Success)
                {
                    Console.WriteLine($"{match.Groups["name"].Value}: {(char)int.Parse(match.Groups["first"].Value)}{(char)int.Parse(match.Groups["second"].Value)}{(char)int.Parse(match.Groups["third"].Value)}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}