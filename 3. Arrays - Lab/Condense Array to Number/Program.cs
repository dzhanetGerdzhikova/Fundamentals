using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            for (int i = num.Length - 1; i > 0; i--)
            {
                int[] currentArray = new int[i];
                for (int x = 0; x < currentArray.Length; x++)
                {
                    currentArray[x] = num[x] + num[x + 1];
                }
                num = currentArray;
            }
            Console.WriteLine(num[0]);
        }
    }
}