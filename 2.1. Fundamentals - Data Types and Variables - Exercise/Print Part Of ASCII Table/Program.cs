using System;

namespace Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secondIndex = int.Parse(Console.ReadLine());

            for (int index = firstIndex; index <= secondIndex; index++)
            {
                Console.Write($"{(char)index} ");
            }
        }
    }
}