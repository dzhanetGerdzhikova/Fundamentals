using System;
using System.Collections.Generic;
using System.Linq;

namespace Battle_Manager
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(":");
            Dictionary<string, People> users = new Dictionary<string, People>();

            while (input[0] != "Results")
            {
                string command = input[0];

                if (command == "Add")
                {
                    string person = input[1];
                    int health = int.Parse(input[2]);
                    int enegy = int.Parse(input[3]);

                    if (users.ContainsKey(person))
                    {
                        users[person].Health += health;
                        //users[person].Energy += enegy;
                    }
                    else
                    {
                        users.Add(person, new People(0, 0));
                        users[person].Health = health;
                        users[person].Energy = enegy;
                    }
                }
                else if (command == "Attack")
                {
                    string attackerName = input[1];
                    string defenderName = input[2];
                    int damage = int.Parse(input[3]);

                    if (users.ContainsKey(attackerName) && users.ContainsKey(defenderName))
                    {
                        users[defenderName].Health -= damage;
                        if (users[defenderName].Health <= 0)
                        {
                            users.Remove(defenderName);
                            Console.WriteLine($"{defenderName} was disqualified!");
                        }

                        users[attackerName].Energy--;
                        if (users[attackerName].Energy <= 0)
                        {
                            users.Remove(attackerName);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                }
                else if (command == "Delete")
                {
                    string userName = input[1];
                    if (userName == "All")
                    {
                        users = new Dictionary<string, People>();
                    }
                    else
                    {
                        users.Remove(userName);
                    }
                }
                input = Console.ReadLine().Split(":");
            }
            Console.WriteLine($"People count: {users.Keys.Count}");

            users = users.OrderByDescending(x => x.Value.Health).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value.Health} - {kvp.Value.Energy}");
            }
        }
    }
}

internal class People
{
    public People(int energy, int health)
    {
        this.Health = health;
        this.Energy = energy;
    }

    public int Health { get; set; }
    public int Energy { get; set; }
}