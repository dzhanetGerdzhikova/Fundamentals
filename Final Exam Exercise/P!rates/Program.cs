using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, City> towns = new Dictionary<string, City>();
            string[] input = Console.ReadLine().Split("||");
            while (input[0] != "Sail")
            {
                string town = input[0];
                int people = int.Parse(input[1]);
                int gold = int.Parse(input[2]);

                if (towns.ContainsKey(town))
                {
                    towns[town].Population += people;
                    towns[town].Gold += gold;
                }
                else
                {
                    towns.Add(town, new City(people, gold));
                }
                input = Console.ReadLine().Split("||");
            }
            input = Console.ReadLine().Split("=>");

            while (input[0] != "End")
            {
                string command = input[0];
                string town = input[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(input[2]);
                    int gold = int.Parse(input[3]);
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    towns[town].Gold -= gold;
                    towns[town].Population -= people;
                    if (towns[town].Gold <= 0 || towns[town].Population <= 0)
                    {
                        towns.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(input[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        towns[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {towns[town].Gold} gold.");
                    }
                }
                input = Console.ReadLine().Split("=>");
            }

            var sortedTowns = towns.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key);
            if (towns.Keys.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Keys.Count} wealthy settlements to go to:");

                foreach (var town in sortedTowns)
                {
                    Console.WriteLine($"{town.Key} -> Population: {town.Value.Population} citizens, Gold: {town.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }

    internal class City
    {
        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }

        public int Population { get; set; }
        public int Gold { get; set; }
    }
}