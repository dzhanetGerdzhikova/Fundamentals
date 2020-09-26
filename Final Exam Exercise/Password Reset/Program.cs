using System;
using System.Linq;
using System.Text;

namespace Password_Reset
{
    internal class Program
    {
        private static object stringBuilder;

        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Done")
            {
                string[] splitedCommands = commands.Split();
                string command = splitedCommands[0];

                if (command == "TakeOdd")
                {
                    //StringBuilder result = new StringBuilder();
                    //for (int i = 0; i < text.Length; i++)
                    //{
                    //    if (i % 2 == 1)
                    //    {
                    //        result.Append(text[i]);
                    //    }
                    //}
                    //text = result.ToString();
                    Console.WriteLine(string.Concat(text.Where((e, i) => i % 2 == 1)));
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(splitedCommands[1]);
                    int length = int.Parse(splitedCommands[2]);
                    StringBuilder result = new StringBuilder(text);

                    result = result.Remove(index, length);
                    text = result.ToString();
                    Console.WriteLine(text);
                }
                else if (command == "Substitute")
                {
                    string substr = splitedCommands[1];
                    string substitute = splitedCommands[2];
                    if (text.Contains(substr))
                    {
                        text = text.Replace(substr, substitute);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {text}");
        }
    }
}