using System;
using System.Collections.Generic;

namespace Email_Validator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Complete")
            {
                if (commands[0] == "Make")
                {
                    string upperOrLower = commands[1];
                    if (upperOrLower == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (commands[0] == "GetDomain")
                {
                    int count = int.Parse(commands[1]);
                    string result = email.Substring(email.Length - count);
                    Console.WriteLine(result);
                }
                else if (commands[0] == "GetUsername")
                {
                    if (!email.Contains('@'))
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                    else
                    {
                        int index = email.IndexOf('@');
                        string result = email.Substring(0, index);
                        Console.WriteLine(result);
                    }
                }
                else if (commands[0] == "Replace")
                {
                    char symbol = char.Parse(commands[1]);
                    email = email.Replace(symbol, '-');
                    Console.WriteLine(email);
                }
                else if (commands[0] == "Encrypt")
                {
                    List<int> ascTable = new List<int>();
                    for (int j = 0; j < email.Length; j++)
                    {
                        ascTable.Add((int)email[j]);
                    }
                    Console.WriteLine(string.Join(" ", ascTable));
                }
                commands = Console.ReadLine().Split();
            }
        }
    }
}