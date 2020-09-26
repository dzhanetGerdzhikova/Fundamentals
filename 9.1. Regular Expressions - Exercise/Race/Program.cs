using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    internal class Program
    {
        private static object dictionary;

        private static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            Dictionary<string, int> nameWithDistance = new Dictionary<string, int>();

            while (input != "end of race")
            {
                var nameOfRacer = string.Join("", Regex.Matches(input, @"(?<name>[A-Za-z])").Select(e => e.Groups["name"].Value));

                List<string> name = new List<string>();
                foreach (Match match in Regex.Matches(input, @"(?<name>[A-Za-z])")) //6 Matches 'G', 'e' , 'o', 'r', 'g', 'e'
                {
                    string currentValue = match.Groups["name"].Value; //G
                    name.Add(currentValue);
                }
                var distance = Regex.Matches(input, @"(?<distance>[0-9])").Select(x => x.Groups["distance"].Value).Select(int.Parse).Sum();
                if (nameWithDistance.ContainsKey(nameOfRacer))
                {
                    nameWithDistance[nameOfRacer] += distance;
                }
                else if (names.Contains(nameOfRacer))
                {
                    nameWithDistance.Add(nameOfRacer, distance);
                }

                input = Console.ReadLine();
            }
            var result = nameWithDistance.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine($"1st place: {result[0]}");
            Console.WriteLine($"2nd place: {result[1]}");
            Console.WriteLine($"3rd place: {result[2]}");
        }
    }
}