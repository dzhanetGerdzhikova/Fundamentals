using System;

namespace NxN_Matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxNMatrix(n);
        }

        private static void NxNMatrix(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= num; col++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}