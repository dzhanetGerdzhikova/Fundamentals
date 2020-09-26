using System;
using System.Text.RegularExpressions;

namespace Match_Dates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var result = Regex.Matches(input, @"(?<day>\d{2})([.|\/|-])(?<month>[A-Z][a-z]{2})(\1)(?<year>\d{4})");

            foreach (Match match in result)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}