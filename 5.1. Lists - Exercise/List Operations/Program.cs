using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();
            string firstCommand = commands[0];

            while (firstCommand != "End")
            {
                if (firstCommand == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbersList.Add(number);
                }
                else if (firstCommand == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    if (index >= 0 && index < numbersList.Count)
                    {
                        numbersList.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (firstCommand == "Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= 0 && index < numbersList.Count)
                    {
                        numbersList.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (firstCommand == "Shift")
                {
                    string secondCommand = commands[1];
                    int count = int.Parse(commands[2]);

                    if (secondCommand == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbersList.Add(numbersList.First());
                            numbersList.RemoveAt(0);
                        }
                    }
                    else if (secondCommand == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbersList.Insert(0, numbersList.Last());
                            numbersList.RemoveAt(numbersList.Count - 1);
                        }
                    }
                }

                commands = Console.ReadLine().Split();
                firstCommand = commands[0];
            }
            Console.WriteLine(string.Join(' ', numbersList));
        }
    }
}