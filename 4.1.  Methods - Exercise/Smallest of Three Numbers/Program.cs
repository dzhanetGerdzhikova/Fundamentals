using System;

namespace Smallest_of_Three_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            SmallestofThreeNumbers(first, second, third);
        }

        private static void SmallestofThreeNumbers(int one, int two, int three)
        {
            if (one <= two && one <= three)
            {
                Console.WriteLine(one);
            }
            else if (two <= one && two <= three)
            {
                Console.WriteLine(two);
            }
            else if (three <= one && three <= two)
            {
                Console.WriteLine(three);
            }
        }
    }
}