using System;

namespace English_Name_of_the_Last_Digit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string num = Console.ReadLine();

            if (num[num.Length - 1] == '0')
            {
                Console.WriteLine("zero");
            }
            else if (num[num.Length - 1] == '1')
            {
                Console.WriteLine("one");
            }
            else if (num[num.Length - 1] == '2')
            {
                Console.WriteLine("two");
            }
            else if (num[num.Length - 1] == '3')
            {
                Console.WriteLine("three");
            }
            else if (num[num.Length - 1] == '4')
            {
                Console.WriteLine("four");
            }
            else if (num[num.Length - 1] == '5')
            {
                Console.WriteLine("five");
            }
            else if (num[num.Length - 1] == '6')
            {
                Console.WriteLine("six");
            }
            else if (num[num.Length - 1] == '7')
            {
                Console.WriteLine("seven");
            }
            else if (num[num.Length - 1] == '8')
            {
                Console.WriteLine("eight");
            }
            else if (num[num.Length - 1] == '9')
            {
                Console.WriteLine("nine");
            }
        }
    }
}