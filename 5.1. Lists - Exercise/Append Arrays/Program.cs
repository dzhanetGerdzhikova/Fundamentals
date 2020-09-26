using System;
using System.Collections.Generic;
using System.Linq;

namespace Append_Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> numberList = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> finalList = new List<string>();

            for (int i = 0; i < numberList.Count - 1; i++)
            {
                numberList.Insert(i, numberList[numberList.Count - 1]);
                numberList.RemoveAt(numberList.Count - 1);
            }

            for (int i = 0; i < numberList.Count; i++)
            {
                finalList.AddRange(numberList[i].Split(" ", StringSplitOptions.RemoveEmptyEntries));
            }
            Console.WriteLine(string.Join(' ', finalList));

            // string newList = string.Join(' ', numberList);
            //numberList = newList.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToList();
            // Console.WriteLine(string.Join(' ',numberList));
        }
    }
}