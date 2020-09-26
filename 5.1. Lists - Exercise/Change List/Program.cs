using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                if (commands[0] == "Delete")
                {
                    numbers.RemoveAll(cells => cells == int.Parse(commands[1]));
                }
                else if (commands[0] == "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index, element);
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}