using System;

namespace Train
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagon = new int[n];
            int sum = 0;
            for (int i = 0; i < wagon.Length; i++)
            {
                wagon[i] = int.Parse(Console.ReadLine());
                sum += wagon[i];
            }
            Console.WriteLine(string.Join(" ", wagon));
            Console.WriteLine(sum);
        }
    }
}