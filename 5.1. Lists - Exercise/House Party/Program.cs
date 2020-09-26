using System;
using System.Collections.Generic;

namespace House_Party
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> namesList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string name = commands[0];

                if (commands[2] == "going!")
                {
                    if (namesList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        namesList.Add(name);
                    }
                }
                else if (commands[2] == "not")
                {
                    if (namesList.Contains(name))
                    {
                        namesList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, namesList));
        }
    }
}