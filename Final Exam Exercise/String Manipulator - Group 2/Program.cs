using System;

namespace String_Manipulator___Group_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Done")
            {
                string command = commands[0];
                if (command == "Change")
                {
                    char symbol = char.Parse(commands[1]);
                    char newSymbol = char.Parse(commands[2]);
                    input = input.Replace(symbol, newSymbol);
                    Console.WriteLine(input);
                }
                else if (command == "Includes")
                {
                    string text = commands[1];
                    if (input.Contains(text))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "End")
                {
                    string text = commands[1];
                    string result = input.Substring(input.Length - text.Length, text.Length);

                    if (result == text)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    char symbol = char.Parse(commands[1]);
                    int result = input.IndexOf(symbol);
                    Console.WriteLine(result);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);
                    string result = input.Substring(startIndex, length);

                    Console.WriteLine(result);
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}