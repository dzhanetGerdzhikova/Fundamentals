using System;

namespace Multiplication_Table_2._0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int startNumber = int.Parse(Console.ReadLine());

            if (startNumber > 10)
            {
                Console.WriteLine($"{input} X {startNumber} = {input * startNumber}");
            }

            for (int i = startNumber; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }
        }
    }
}