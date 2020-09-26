using System;
using System.Text;

namespace Nikulden_s_Charity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder code = new StringBuilder(Console.ReadLine());

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Finish")
            {
                string command = commands[0];
                if (command == "Replace")
                {
                    string currentChar = commands[1];
                    string newtChar = commands[2];

                    code = code.Replace(currentChar, newtChar);
                    Console.WriteLine(code.ToString());
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    if (startIndex < 0 || startIndex >= code.Length || endIndex < 0 || endIndex >= code.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        code = code.Remove(startIndex, endIndex);
                        Console.WriteLine(code.ToString());
                    }
                }
                else if (command == "Make")
                {
                    string upperOrLower = commands[1];
                    if (upperOrLower == "Upper")
                    {
                        code = code.Replace(code.ToString(), code.ToString().ToUpper());
                        Console.WriteLine(code.ToString());
                    }
                    else if (upperOrLower == "Lower")
                    {
                        code = code.Replace(code.ToString(), code.ToString().ToLower());
                        Console.WriteLine(code.ToString());
                    }
                }
                else if (command == "Check")
                {
                    string text = commands[1];
                    if (code.ToString().Contains(text))
                    {
                        Console.WriteLine($"Message contains {text}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {text}");
                    }
                }
                else if (command == "Sum")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    if (startIndex < 0 || startIndex >= code.Length || endIndex < 0 || endIndex >= code.Length)
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                    else
                    {
                        int sum = 0;
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += (int)code[i];
                        }
                        Console.WriteLine(sum);
                    }
                }

                commands = Console.ReadLine().Split();
            }
        }
    }
}