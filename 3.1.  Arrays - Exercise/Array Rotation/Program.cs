using System;
using System.Linq;

namespace test
{
    internal class Program
    {
        private static void Main()

        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] secondArray = new int[array.Length];

                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (j + 1 >= secondArray.Length)
                    {
                        secondArray[j] = array[j + 1 - secondArray.Length];
                    }
                    else
                    {
                        secondArray[j] = array[j + 1];
                    }
                }
                array = secondArray;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}