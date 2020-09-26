using System;
using System.Linq;

namespace Word_Filter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            words.Where(x => x.Length % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}