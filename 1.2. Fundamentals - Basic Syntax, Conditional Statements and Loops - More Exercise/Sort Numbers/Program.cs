using System;

namespace Sort_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int max = int.MinValue; ;
            int mid = 0;
            int min = int.MaxValue; ;
            if (secondNum == firstNum || secondNum == thirdNum)
            {
                mid = secondNum;
            }

            if (firstNum == thirdNum)
            {
                mid = firstNum;
            }
            if (firstNum < min)
            {
                min = firstNum;
            }
            if (secondNum < min)
            {
                min = secondNum;
            }
            if (thirdNum < min)
            {
                min = thirdNum;
            }

            if (firstNum > max)
            {
                max = firstNum;
            }
            if (secondNum > max)
            {
                max = secondNum;
            }
            if (thirdNum > max)
            {
                max = thirdNum;
            }

            if (firstNum != max && firstNum != min)
            {
                mid = firstNum;
            }

            if (secondNum != max && secondNum != min)
            {
                mid = secondNum;
            }
            if (thirdNum != max && thirdNum != min)
            {
                mid = thirdNum;
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}