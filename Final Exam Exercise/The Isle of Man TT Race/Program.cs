using System;
using System.Text;
using System.Text.RegularExpressions;

namespace The_Isle_of_Man_TT_Race
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, @"([#$%*&])(?<name>[A-Za-z]+)(\1)=(?<length>[0-9]+)!!(?<code>.+$)");
                if (match.Success)
                {
                    if (int.Parse(match.Groups["length"].Value) == match.Groups["code"].Value.Length)
                    {
                        StringBuilder result = new StringBuilder();

                        for (int i = 0; i < match.Groups["code"].Value.Length; i++)
                        {
                            result.Append((char)((int)(match.Groups["code"].Value[i]) + int.Parse(match.Groups["length"].Value)));
                        }
                        Console.WriteLine($"Coordinates found! {match.Groups["name"].Value} -> {result}");
                        return;
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
            }
        }
    }
}