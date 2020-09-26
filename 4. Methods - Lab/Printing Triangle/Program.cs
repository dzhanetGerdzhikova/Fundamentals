using System;

namespace Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           PrintTriangle(n);
        }
        static void PrintTriangle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <=row; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
            for (int row = number-1; row > 0; row--)
            {
                for (int col = 1; col <=row; col++)
                {
                    Console.Write(col+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
