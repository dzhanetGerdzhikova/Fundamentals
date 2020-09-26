using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Password
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, @"(.+)>(?<numbers>\d{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]+)\|(?<symbols>[^<>]{3})<(\1)$");

                if (match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(match.Groups["numbers"].Value);
                    sb.Append(match.Groups["lower"].Value);
                    sb.Append(match.Groups["upper"].Value);
                    sb.Append(match.Groups["symbols"].Value);
                    Console.WriteLine($"Password: {sb}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}