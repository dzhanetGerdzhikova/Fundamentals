using System;
using System.Linq;

namespace Rounding_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            double[] nums = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            int[] roundedNums = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                double currentNum = nums[i];
                int roundedNum = (int)Math.Round(currentNum, MidpointRounding.AwayFromZero);
                roundedNums[i] = roundedNum;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{nums[i]} => {roundedNums[i]}");
            }
        }
    }
}