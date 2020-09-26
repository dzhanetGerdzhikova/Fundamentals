using System;

namespace Multiplication_Table
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }
        }
    }
}