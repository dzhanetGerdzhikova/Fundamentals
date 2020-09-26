using System;

namespace Math_Power
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberOnPower(num, count));
        }

        private static decimal NumberOnPower(decimal num, int pow)
        {
            decimal firstNum = 1;
            for (int i = 0; i < pow; i++)
            {
                firstNum *= num;
            }
            return firstNum;
        }
    }
}