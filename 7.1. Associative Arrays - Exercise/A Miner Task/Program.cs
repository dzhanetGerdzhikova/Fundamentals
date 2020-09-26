using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            Dictionary<string, int> resourseWithQuantity = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int currentCuantity = int.Parse(Console.ReadLine());

                if (!resourseWithQuantity.ContainsKey(resource))
                {
                    resourseWithQuantity.Add(resource, currentCuantity);
                }
                else
                {
                    resourseWithQuantity[resource] += currentCuantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var cell in resourseWithQuantity)
            {
                Console.WriteLine($"{cell.Key} -> {cell.Value}");
            }
        }
    }
}