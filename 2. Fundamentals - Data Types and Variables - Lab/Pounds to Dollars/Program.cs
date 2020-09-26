using System;

namespace Pounds_to_Dollars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal convertToUsd = pounds * 1.31m;

            Console.WriteLine($"{convertToUsd:f3}");
        }
    }
}