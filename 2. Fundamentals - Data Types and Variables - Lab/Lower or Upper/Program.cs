using System;

namespace Lower_or_Upper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            if (symbol >= 'a' && symbol <= 'z')
            {
                Console.WriteLine("lower-case");
            }
            else if (symbol >= 'A' && symbol <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}