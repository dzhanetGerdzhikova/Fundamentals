using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < Math.Min(firstHand.Count, secondHand.Count); i++)
            {
                if (firstHand[i] == secondHand[i])
                {
                    firstHand.RemoveAt(i);
                    secondHand.RemoveAt(i);
                }
                else if (firstHand[i] > secondHand[i])
                {
                    firstHand.Add(firstHand[i]);
                    firstHand.Add(secondHand[i]);
                    firstHand.Remove(firstHand[i]);
                    secondHand.Remove(secondHand[i]);
                }
                else if (secondHand[i] > firstHand[i])
                {
                    secondHand.Add(secondHand[i]);
                    secondHand.Add(firstHand[i]);
                    secondHand.Remove(secondHand[i]);
                    firstHand.Remove(firstHand[i]);
                }
                i--;
            }
            if (firstHand.Count > secondHand.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
        }
    }
}