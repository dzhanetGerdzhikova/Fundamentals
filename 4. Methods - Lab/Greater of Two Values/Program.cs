using System;

namespace Greater_of_Two_Values
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GreaterOfTwoValues(num1, num2));
            }
            else if (input == "char")
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GreaterOfTwoValues(char1, char2));
            }
            else if (input == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GreaterOfTwoValues(first, second));
            }
        }

        private static int GreaterOfTwoValues(int num1, int num2)
        {
            int result = 0;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }

        private static char GreaterOfTwoValues(char first, char second)
        {
            char result = ' ';
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;
        }

        private static string GreaterOfTwoValues(string first, string second)
        {
            string result = string.Empty;

            if (first.CompareTo(second) >= 0)
            {
                result = first;
            }
            else
            {
                result = second;
            }

            return result;
        }
    }
}