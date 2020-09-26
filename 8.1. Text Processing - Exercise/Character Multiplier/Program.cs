using System;
using System.Collections.Generic;
using System.Linq;

namespace Character_Multiplier
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            SumOfChars(input[0], input[1]);
        }

        private static void SumOfChars(string first, string second)
        {
            double sum = 0;
            List<char> firstWord = first.ToCharArray().ToList();
            List<char> secondWord = first.ToCharArray().ToList();

            for (int i = 0; i < MathF.Max(first.Length, second.Length); i++)
            {
                if (first.Length > i && second.Length > i)
                {
                    sum += first[i] * second[i];
                }
                else
                {
                    sum += first.Length > second.Length ? first[i] : second[i];
                    //if (first.Length > second.Length)
                    //{
                    //    sum += first[i];
                    //}
                    //else
                    //{
                    //    sum += second[i];
                    //}
                }
            }
            Console.WriteLine(sum);
        }
    }
}