using System;

namespace Add_and_Subtract
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNUm = int.Parse(Console.ReadLine());
            int thirdNUm = int.Parse(Console.ReadLine());
            Substract(Sum(firstNum, secondNUm), thirdNUm);
        }

        private static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        private static void Substract(int sum, int num)
        {
            int result = sum - num;
            Console.WriteLine(result);
        }
    }
}