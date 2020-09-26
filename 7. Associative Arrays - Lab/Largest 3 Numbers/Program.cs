using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.OrderByDescending(x => x).Take(3).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}