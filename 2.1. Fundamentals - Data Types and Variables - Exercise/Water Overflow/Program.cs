using System;

namespace Water_Overflow
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int maxCapacity = 255;
            int littersInTank = 0;

            for (int currentLine = 0; currentLine < numOfLines; currentLine++)
            {
                int quantities = int.Parse(Console.ReadLine());

                if (quantities > maxCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    maxCapacity -= quantities;
                    littersInTank += quantities;
                }
            }
            Console.WriteLine(littersInTank);
        }
    }
}