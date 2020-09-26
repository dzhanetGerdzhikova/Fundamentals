using System;
using System.Collections.Generic;
using System.Linq;

namespace Inbox_Manager
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("->");

            Dictionary<string, List<string>> userWithEmail = new Dictionary<string, List<string>>();

            while (input[0] != "Statistics")
            {
                string command = input[0];
                string userName = input[1];

                if (command == "Add")
                {
                    if (userWithEmail.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                    else
                    {
                        userWithEmail.Add(userName, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    string email = input[2];
                    userWithEmail[userName].Add(email);
                }
                else if (command == "Delete")
                {
                    if (userWithEmail.ContainsKey(userName))
                    {
                        userWithEmail.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }

                input = Console.ReadLine().Split("->");
            }
            Console.WriteLine($"Users count: {userWithEmail.Keys.Count}");
            userWithEmail = userWithEmail.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var user in userWithEmail)
            {
                Console.WriteLine(user.Key);
                foreach (var text in user.Value)
                {
                    Console.WriteLine($"- {text}");
                }
            }
        }
    }
}