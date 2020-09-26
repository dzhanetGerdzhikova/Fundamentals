using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages_Manager
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Dictionary<string, User> users = new Dictionary<string, User>();

            while (input != "Statistics")
            {
                string[] splitedInput = input.Split("=");
                string command = splitedInput[0];

                if (command == "Add")
                {
                    string userName = splitedInput[1];
                    int sentSms = int.Parse(splitedInput[2]);
                    int receiveSms = int.Parse(splitedInput[3]);
                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName, new User(sentSms, receiveSms));
                    }
                }
                else if (command == "Message")
                {
                    string sender = splitedInput[1];
                    string receiver = splitedInput[2];
                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender].SentSms++;
                        users[receiver].ReceiveSms++;
                        if (users[sender].SentSms + users[sender].ReceiveSms >= 10)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            users.Remove(sender);
                        }
                        if (users[receiver].SentSms + users[receiver].ReceiveSms >= 10)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            users.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string userName = splitedInput[1];
                    if (userName == "All")
                    {
                        users = new Dictionary<string, User>();
                    }
                    else
                    {
                        users.Remove(userName);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {users.Keys.Count}");

            users = users.OrderByDescending(x => x.Value.ReceiveSms).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} - {user.Value.SentSms + user.Value.ReceiveSms}");
            }
        }

        private class User
        {
            public User(int sent, int receive)
            {
                this.SentSms = sent;
                this.ReceiveSms = receive;
            }

            public int SentSms { get; set; }
            public int ReceiveSms { get; set; }
        }
    }
}