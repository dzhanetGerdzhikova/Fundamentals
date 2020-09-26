using System;
using System.Linq;

namespace Common_Elements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] arrayFirst = Console.ReadLine()
                 .Split()
                 .ToArray();
            string[] arraySecond = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < arraySecond.Length; i++)
            {
                if (arrayFirst.Contains(arraySecond[i]))
                {
                    Console.Write(arraySecond[i] + " ");
                }
                //for (int j = 0; j < arrayFirst.Length; j++)
                //{
                //    if(arraySecond[i]==arrayFirst[j])
                //    {
                //        Console.Write(arraySecond[i]+" ");
                //    }
                //}
            }
        }
    }
}