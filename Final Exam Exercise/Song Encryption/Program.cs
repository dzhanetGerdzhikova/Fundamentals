using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Song_Encryption
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                Match match = Regex.Match(input, @"^(?<name>[A-Z][a-z\s']*):(?<song>[A-Z\s]+)$");

                if (match.Success)
                {
                    int count = match.Groups["name"].Length;
                    StringBuilder result = new StringBuilder();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != '\'' && input[i] != ' ' && input[i] != ':')
                        {
                            if (input[i] >= 'a' && input[i] <= 'z')
                            {
                                if ((input[i] + count) > 'z')
                                {
                                    result.Append((char)((input[i] + count) - 'z' + 'a' - 1));
                                }
                                else
                                {
                                    result.Append((char)(input[i] + count));
                                }
                            }
                            else if (input[i] >= 'A' && input[i] <= 'Z')
                            {
                                if ((input[i] + count) > 'Z')
                                {
                                    result.Append((char)((input[i] + count) - 'Z' + 'A' - 1));
                                }
                                else
                                {
                                    result.Append((char)(input[i] + count));
                                }
                            }
                        }
                        else if (input[i] == ':')
                        {
                            result.Append('@');
                        }
                        else
                        {
                            result.Append(input[i]);
                        }
                    }
                    Console.WriteLine($"Successful encryption: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }
    }
}