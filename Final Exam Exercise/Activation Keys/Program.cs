using System;
using System.Text;

namespace Activation_Keys
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = Console.ReadLine().Split(">>>");

            while (commands[0] != "Generate")
            {
                string command = commands[0];
                if (command == "Contains")
                {
                    string text = commands[1];
                    if (input.Contains(text))
                    {
                        Console.WriteLine($"{input} contains {text}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string upperOrLower = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);

                    StringBuilder newResult = new StringBuilder(input);

                    if (upperOrLower == "Upper")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            newResult[i] = char.Parse(newResult[i].ToString().ToUpper());
                        }
                        //string newInput = input.Substring(startIndex, endIndex - startIndex).ToUpper();
                        //string firstText = input.Substring(0, startIndex);
                        //string lastText = input.Substring(endIndex, input.Length - endIndex);
                        //input = firstText + newInput + lastText;
                    }
                    else if (upperOrLower == "Lower")
                    {
                        for (int i = startIndex; i < endIndex; i++)
                        {
                            newResult[i] = char.Parse(newResult[i].ToString().ToLower());
                        }
                        //string newInput = input.Substring(startIndex, endIndex - startIndex).ToLower();
                        //string firstText = input.Substring(0, startIndex);
                        //string lastText = input.Substring(endIndex, input.Length - endIndex);
                        //input = firstText + newInput + lastText;
                    }
                    input = newResult.ToString();
                    //Console.WriteLine($"{input}");
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);

                    input = input.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(input);
                }

                commands = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}