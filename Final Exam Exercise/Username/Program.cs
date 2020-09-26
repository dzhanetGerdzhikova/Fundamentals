using System;
using System.Linq;

namespace Username
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string commandLineInput = Console.ReadLine();

            while (commandLineInput != "Sign up")
            {
                string[] input = commandLineInput.Split();
                string command = input[0];

                if (command == "Case")
                {
                    string upperOrLower = input[1];
                    if (upperOrLower == "upper")
                    {
                        userName = userName.ToUpper();
                        Console.WriteLine(userName);
                    }
                    else
                    {
                        userName = userName.ToLower();
                        Console.WriteLine(userName);
                    }
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    if (startIndex >= 0 && startIndex < endIndex && endIndex < userName.Length)
                    {
                        var result = userName.Substring(startIndex, endIndex - startIndex + 1).ToCharArray().Reverse();
                        Console.WriteLine(string.Join("", result));
                    }
                }
                else if (command == "Cut")
                {
                    string substring = input[1];
                    if (userName.Contains(substring))
                    {
                        int index = userName.IndexOf(substring);
                        string result = userName.Remove(index, substring.Length);
                        Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine($"The word {userName} doesn't contain {substring}.");
                    }
                }
                else if (command == "Replace")
                {
                    char symbol = char.Parse(input[1]);
                    userName = userName.Replace(symbol, '*');
                    Console.WriteLine(userName);
                }
                else if (command == "Check")
                {
                    char symbol = char.Parse(input[1]);
                    if (userName.Contains(symbol))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {symbol}.");
                    }
                }
                commandLineInput = Console.ReadLine();
            }
        }
    }
}