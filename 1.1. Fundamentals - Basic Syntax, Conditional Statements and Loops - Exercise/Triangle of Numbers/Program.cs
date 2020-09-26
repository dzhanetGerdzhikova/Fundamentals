using System;

namespace Triangle_of_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            for (int row = 1; row <= num; row++)
            {
                for (int colum = 1; colum <= row; colum++)
                {
                    Console.Write(n + " ");
                }

                n++;
                Console.WriteLine();
            }
        }
    }
}