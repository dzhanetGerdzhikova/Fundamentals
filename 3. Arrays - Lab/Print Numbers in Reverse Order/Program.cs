using System;
using System.Linq;

namespace Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            string text = "";

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                text += numbers[i] + " ";
            }

            Console.Write(text);
            int[] num = text
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(num);
        }
    }
}