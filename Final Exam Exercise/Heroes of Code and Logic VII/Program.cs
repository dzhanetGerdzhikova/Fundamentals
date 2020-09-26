using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < countLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int points = int.Parse(input[1]);
                int mana = int.Parse(input[2]);

                heroes.Add(name, new Hero(points, mana));
            }
            string input2 = Console.ReadLine();
            while (input2 != "End")
            {
                string[] splitedInput = input2.Split(" - ");

                string command = splitedInput[0];
                string name = splitedInput[1];

                if (command == "CastSpell")
                {
                    int manaNeeded = int.Parse(splitedInput[2]);
                    string spellName = splitedInput[3];
                    if (heroes[name].Mana >= manaNeeded)
                    {
                        heroes[name].Mana -= manaNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(splitedInput[2]);
                    string attackerName = splitedInput[3];
                    heroes[name].Point -= damage;
                    if (heroes[name].Point > 0)
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attackerName} and now has {heroes[name].Point} HP left!");
                    }
                    else
                    {
                        heroes.Remove(name);
                        Console.WriteLine($"{name} has been killed by {attackerName}!");
                    }
                }
                else if (command == "Recharge")
                {
                    int amount = int.Parse(splitedInput[2]);
                    int currentMana = heroes[name].Mana;
                    heroes[name].Mana += amount;
                    if (heroes[name].Mana > 200)
                    {
                        heroes[name].Mana = 200;
                        Console.WriteLine($"{name} recharged for {200 - currentMana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }
                }
                else if (command == "Heal")
                {
                    int amount = int.Parse(splitedInput[2]);
                    int currentPoint = heroes[name].Point;
                    heroes[name].Point += amount;

                    if (heroes[name].Point > 100)
                    {
                        Console.WriteLine($"{name} healed for {100 - currentPoint} HP!");
                        heroes[name].Point = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }
                }
                input2 = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(x => x.Value.Point).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.Point}");
                Console.WriteLine($"  MP: {hero.Value.Mana}");
            }
        }
    }

    internal class Hero
    {
        public Hero(int point, int mana)
        {
            this.Point = point;
            this.Mana = mana;
        }

        public int Point { get; set; }
        public int Mana { get; set; }
    }
}