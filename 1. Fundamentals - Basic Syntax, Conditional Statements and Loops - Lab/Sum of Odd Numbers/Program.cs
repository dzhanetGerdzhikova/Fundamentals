using System;

namespace Sum_of_Odd_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = 1;
            int sumOddNumber = 0;
            for (int countNum = 1; countNum <= num; countNum++)
            {
                Console.WriteLine(number);
                sumOddNumber += number;
                number += 2;
            }
            Console.WriteLine($"Sum: {sumOddNumber}");
        }
    }
}