using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_Sessions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> racers = new Dictionary<string, List<string>>();

            while (input != "END")
            {
                string[] splitedInput = input.Split("->");
                string command = splitedInput[0];

                if (command == "Add")
                {
                    string road = splitedInput[1];
                    string racer = splitedInput[2];

                    if (!racers.ContainsKey(road))
                    {
                        racers.Add(road, new List<string>());
                        racers[road].Add(racer);
                    }
                    else
                    {
                        racers[road].Add(racer);
                    }
                }
                else if (command == "Move")
                {
                    string currentRoad = splitedInput[1];
                    string racer = splitedInput[2];
                    string nextRoad = splitedInput[3];
                    if (racers[currentRoad].Contains(racer))
                    {
                        racers[currentRoad].Remove(racer);
                        racers[nextRoad].Add(racer);
                    }
                }
                else if (command == "Close")
                {
                    string road = splitedInput[1];
                    if (racers.ContainsKey(road))
                    {
                        racers.Remove(road);
                    }
                }

                input = Console.ReadLine();
            }
            racers = racers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Practice sessions:");

            foreach (var kvp in racers)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var racer in kvp.Value)
                {
                    Console.WriteLine($"++{racer}");
                }
            }
        }
    }
}