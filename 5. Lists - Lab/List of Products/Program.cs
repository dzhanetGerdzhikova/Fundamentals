using System;
using System.Collections.Generic;

namespace List_of_Products
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> orderList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string productName = Console.ReadLine();
                orderList.Add(productName);
            }
            orderList.Sort();
            for (int i = 0; i < orderList.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{orderList[i]}");
            }
        }
    }
}