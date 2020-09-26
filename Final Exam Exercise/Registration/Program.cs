using System;
using System.Text.RegularExpressions;

namespace Registration
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            int countSuccess = 0;
            for (int i = 0; i < countLines; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, @"U\$(?<name>[A-Z][a-z]{2,})U\$P\@\$(?<password>[A-Za-z]{5,}[0-9]+)P\@\$");
                if (match.Success)
                {
                    countSuccess++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["name"].Value}, Password: {match.Groups["password"].Value}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {countSuccess}");
        }
    }
}