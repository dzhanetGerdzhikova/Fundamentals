using System;
using System.Text;

namespace Warrior_s_Quest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder code = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "For Azeroth")
            {
                string[] input = command.Split();
                string typeCommand = input[0];
                if (typeCommand == "GladiatorStance")
                {
                    code.Replace(code.ToString(), code.ToString().ToUpper());
                    Console.WriteLine(code.ToString());
                }
                else if (typeCommand == "DefensiveStance")
                {
                    code.Replace(code.ToString(), code.ToString().ToLower());
                    Console.WriteLine(code.ToString());
                }
                else if (typeCommand == "Dispel")
                {
                    int index = int.Parse(input[1]);
                    char letter = char.Parse(input[2]);
                    if (index < 0 || index >= code.Length)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {
                        code[index] = letter;
                        Console.WriteLine("Success!");
                    }
                }
                else if (typeCommand == "Target")
                {
                    string otherCommand = input[1];
                    if (otherCommand == "Change")
                    {
                        string firstSubstring = input[2];
                        string secondSubstring = input[3];
                        code.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(code.ToString());
                    }
                    else if (otherCommand == "Remove")
                    {
                        string substring = input[2];
                        int index = code.ToString().IndexOf(substring);
                        if (index > -1)
                        {
                            code.Remove(index, substring.Length);
                            Console.WriteLine(code.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                command = Console.ReadLine();
            }
        }
    }
}