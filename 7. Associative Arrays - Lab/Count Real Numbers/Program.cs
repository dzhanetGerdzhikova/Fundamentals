using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Real_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            SortedDictionary<int, int> countOfNumbers = new SortedDictionary<int, int>();
            int value = 0;
            foreach (var number in numbers)
            {
                if (!countOfNumbers.ContainsKey(number))
                {
                    countOfNumbers.Add(number, value);
                }
                countOfNumbers[number]++;
            }

            foreach (var cell in countOfNumbers)
            {
                Console.WriteLine($"{cell.Key} -> {cell.Value}");
            }
        }
    }
}