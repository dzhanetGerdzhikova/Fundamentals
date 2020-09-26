using System;
using System.Collections.Generic;

namespace _4._Orders
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string product = input[0];

            Dictionary<string, Product> productsPrice = new Dictionary<string, Product>();

            while (product != "buy")
            {
                double price = double.Parse(input[1]);
                int currentquantity = int.Parse(input[2]);

                if (!productsPrice.ContainsKey(product))
                {
                    productsPrice.Add(product, new Product() { Price = price, Quantity = currentquantity });
                }
                else
                {
                    productsPrice[product].Price = price;
                    productsPrice[product].Quantity += currentquantity;
                }

                input = Console.ReadLine().Split();
                product = input[0];
            }

            foreach (var cell in productsPrice)
            {
                Console.WriteLine($"{cell.Key} -> {cell.Value.Quantity * cell.Value.Price:f2}");
            }
        }
    }

    internal class Product
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}