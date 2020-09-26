using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Arriving_in_Kathmandu
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "Last note")
            {
                Match match = Regex.Match(input, @"^(?<name>[A-Za-z0-9!@#$?]+)=(?<length>[0-9]+)<<(?<code>.+)$");
                if (match.Success)
                {
                    if (int.Parse(match.Groups["length"].Value) == match.Groups["code"].Value.Length)
                    {
                        MatchCollection name = Regex.Matches(match.Groups["name"].Value, @"(?<newName>[^0-9!@?#$])");
                        string result = string.Join("", name.Select(e => e.Value));

                        Console.WriteLine($"Coordinates found! {result} -> {match.Groups["code"].Value}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }

                input = Console.ReadLine();
            }
        }
    }
}