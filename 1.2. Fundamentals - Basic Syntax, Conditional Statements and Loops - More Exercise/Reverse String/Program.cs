using System;

namespace Reverse_String
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write((char)input[i]);
            }
        }
    }
}