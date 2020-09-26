using System;

namespace String_Manipulator___Group_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "End")
            {
                string command = commands[0];

                if (command == "Translate")
                {
                    char symbol = char.Parse(commands[1]);
                    char replacement = char.Parse(commands[2]);
                    input = input.Replace(symbol, replacement);
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
                else if (command == "Start")
                {
                    string text = commands[1];
                    string result = input.Substring(0, text.Length);
                    if (text == result)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (command == "FindIndex")
                {
                    char symbol = char.Parse(commands[1]);
                    int index = input.LastIndexOf(symbol);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);
                    input = input.Remove(index, count);

                    Console.WriteLine(input);
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}