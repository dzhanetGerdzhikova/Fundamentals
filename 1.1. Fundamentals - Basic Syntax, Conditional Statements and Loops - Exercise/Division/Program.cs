using System;

namespace Division
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int divisible = 0;

            if (input % 2 == 0)
            {
                divisible = 2;
            }
            if (input % 3 == 0)
            {
                divisible = 3;
            }
            if (input % 6 == 0)
            {
                divisible = 6;
            }
            if (input % 7 == 0)
            {
                divisible = 7;
            }
            if (input % 10 == 0)
            {
                divisible = 10;
            }

            if (divisible == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divisible}");
            }
        }
    }
}