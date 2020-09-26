using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());
            Dictionary<string, string> userWithCarRegistration = new Dictionary<string, string>();

            for (int i = 0; i < countInput; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string carRestration = input[2];

                    if (!userWithCarRegistration.ContainsKey(name))
                    {
                        userWithCarRegistration.Add(name, carRestration);
                        Console.WriteLine($"{name} registered {carRestration} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {userWithCarRegistration[name]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!userWithCarRegistration.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        userWithCarRegistration.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (var cell in userWithCarRegistration)
            {
                Console.WriteLine($"{cell.Key} => {cell.Value}");
            }
        }
    }
}