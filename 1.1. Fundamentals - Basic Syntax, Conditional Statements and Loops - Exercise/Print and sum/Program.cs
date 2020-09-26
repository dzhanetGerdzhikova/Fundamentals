using System;

namespace Print_and_sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endtNum = int.Parse(Console.ReadLine());

            int sumNums = 0;
            for (int num = startNum; num <= endtNum; num++)
            {
                Console.Write(num + " ");
                sumNums += num;
            }
            Console.WriteLine();
            Console.WriteLine("Sum: " + sumNums);
        }
    }
}