using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = numbersList.IndexOf(bomb[0]);
            int count = bomb[1];

            while (index >= 0)
            {
                List<int> newList = new List<int>();

                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (i < index - count || i > index + count)
                    {
                        newList.Add(numbersList[i]);
                    }
                }
                numbersList = newList;
                index = numbersList.IndexOf(bomb[0]);
            }

            Console.WriteLine(numbersList.Sum());
        }
    }
}