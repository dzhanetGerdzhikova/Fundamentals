using System;

namespace Spice_Must_Flow
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int totalSpices = int.Parse(Console.ReadLine());

            int days = 0;
            int workersConsume = 26;
            int totalWorkersConsume = 0;
            if (totalSpices < 0)
            {
                return;
            }
            while (totalSpices >= 100)
            {
                days++;
                int spice = totalSpices;
                spice -= workersConsume;
                totalWorkersConsume += spice;
                totalSpices -= 10;
            }
            if (workersConsume < totalWorkersConsume)
            {
                totalWorkersConsume -= workersConsume;
            }
            Console.WriteLine($"{days}");
            Console.WriteLine($"{totalWorkersConsume}");
        }
    }
}