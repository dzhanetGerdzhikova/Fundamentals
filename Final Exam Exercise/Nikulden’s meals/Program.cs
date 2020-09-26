using System;
using System.Collections.Generic;
using System.Linq;

namespace Nikulden_s_meals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("-");
            Dictionary<string, List<string>> likedMeal = new Dictionary<string, List<string>>();
            List<string> unlikedMeals = new List<string>();

            while (input[0] != "Stop")
            {
                string command = input[0];
                string guest = input[1];
                string meal = input[2];

                if (command == "Like")
                {
                    if (!likedMeal.ContainsKey(guest))
                    {
                        likedMeal.Add(guest, new List<string>());
                        likedMeal[guest].Add(meal);
                    }
                    else if (likedMeal[guest].Contains(meal))
                    {
                    }
                    else
                    {
                        likedMeal[guest].Add(meal);
                    }
                }
                else if (command == "Unlike")
                {
                    if (!likedMeal.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                    else if (likedMeal[guest].Contains(meal))
                    {
                        Console.WriteLine($"{guest} doesn't like the {meal}.");
                        unlikedMeals.Add(meal);
                        likedMeal[guest].Remove(meal);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    }
                }

                input = Console.ReadLine().Split("-");
            }

            likedMeal = likedMeal.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var guest in likedMeal)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {unlikedMeals.Count}");
        }
    }
}