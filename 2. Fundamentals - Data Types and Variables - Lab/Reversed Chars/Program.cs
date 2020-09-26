using System;

namespace Reversed_Chars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            Console.Write($"{third} {second} {first}");
        }
    }
}