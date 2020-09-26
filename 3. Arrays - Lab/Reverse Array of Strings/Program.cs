using System;
using System.Linq;

namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < symbols.Length / 2; i++)
            {
                string first = symbols[i];
                string last = symbols[symbols.Length - 1 - i];

                symbols[i] = last;
                symbols[symbols.Length - 1 - i] = first;
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write(symbols[i] + " ");
            }
        }
    }
}