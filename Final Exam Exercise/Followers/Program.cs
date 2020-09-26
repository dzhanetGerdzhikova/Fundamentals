using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, User> followerWithLikes = new Dictionary<string, User>();

            while (input != "Log out")
            {
                string[] splitedInput = input.Split(": ");
                string command = splitedInput[0];
                string user = splitedInput[1];

                if (command == "New follower")
                {
                    if (!followerWithLikes.ContainsKey(user))
                    {
                        followerWithLikes.Add(user, new User(0, 0));
                    }
                }
                else if (command == "Like")
                {
                    int count = int.Parse(splitedInput[2]);
                    if (!followerWithLikes.ContainsKey(user))
                    {
                        followerWithLikes.Add(user, new User(0, 0));
                        followerWithLikes[user].Likes += count;
                    }
                    else
                    {
                        followerWithLikes[user].Likes += count;
                    }
                }
                else if (command == "Comment")
                {
                    if (!followerWithLikes.ContainsKey(user))
                    {
                        followerWithLikes.Add(user, new User(0, 0));
                        followerWithLikes[user].Comments++; ;
                    }
                    else
                    {
                        followerWithLikes[user].Comments++;
                    }
                }
                else if (command == "Blocked")
                {
                    if (!followerWithLikes.ContainsKey(user))
                    {
                        Console.WriteLine($"{user} doesn't exist.");
                    }
                    else
                    {
                        followerWithLikes.Remove(user);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(followerWithLikes.Keys.Count + " followers");

            followerWithLikes = followerWithLikes.OrderByDescending(x => x.Value.Likes).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var name in followerWithLikes)
            {
                int count = name.Value.Likes + name.Value.Comments;
                Console.WriteLine($"{name.Key}: {count}");
            }
        }

        private class User
        {
            public User(int likes, int comments)
            {
                this.Likes = likes;
                this.Comments = comments;
            }

            public int Likes { get; set; }
            public int Comments { get; set; }
        }
    }
}