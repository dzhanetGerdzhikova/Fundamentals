﻿using System;

namespace Repeat_Strings
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    Console.Write(input[i]);
                }
            }
        }
    }
}