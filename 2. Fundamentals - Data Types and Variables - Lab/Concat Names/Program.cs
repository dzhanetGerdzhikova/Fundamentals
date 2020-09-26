using System;

namespace Concat_Names
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string laskatName = Console.ReadLine();
            string symbol = Console.ReadLine();

            Console.WriteLine($"{firstName}{symbol}{laskatName}");
        }
    }
}