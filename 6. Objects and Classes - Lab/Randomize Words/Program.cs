using System;
using System.Collections.Generic;
using System.Linq;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Random number = new Random();

            for (int i = 0; i < input.Count; i++)
            {
                int index = number.Next(0,input.Count);

                string currentEl = input[i];
                input[i] = input[index];
                input[index] = currentEl;

            }

            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
