using System;
using System.Linq;

namespace Kamino_Factory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countOfElements = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int maxCount = int.MinValue;
            int[] bestDna = new int[countOfElements];
            int currentDna = 0;
            int bestCountOfDna = 0;
            int bestSum = 0;
            while (input != "Clone them!")
            {
                int[] nums = input.Split('!').Select(int.Parse).ToArray();
                int sum = 0;
                currentDna++;
                int count = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
        }
    }
}