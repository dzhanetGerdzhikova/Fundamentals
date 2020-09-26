using System;

namespace Top_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (IsDivideBy8(i) && AreHaveOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDivideBy8(int number)
        {
            int sum = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                sum += int.Parse(number.ToString()[i].ToString());
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool AreHaveOddDigit(int numbre)
        {
            int counter = 0;
            for (int i = 0; i < numbre.ToString().Length; i++)
            {
                if (int.Parse(numbre.ToString()[i].ToString()) % 2 == 1)
                {
                    counter++;
                }
            }
            if (counter >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}