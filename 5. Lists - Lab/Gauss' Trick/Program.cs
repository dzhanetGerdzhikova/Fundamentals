﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss__Trick
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int firstListLenght = numbers.Count / 2;

            for (int i = 0; i < firstListLenght; i++)
            {
                numbers[i] = numbers[i] + numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}