using System;

namespace Orders
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            PriceOfOrder(product, count);
        }

        private static void PriceOfOrder(string product, int count)
        {
            decimal price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50m;
                    break;

                case "water":
                    price = 1.00m;
                    break;

                case "coke":
                    price = 1.40m;
                    break;

                case "snacks":
                    price = 2.00m;
                    break;

                default:
                    break;
            }
            Console.WriteLine($"{price * count:f2}");
        }
    }
}