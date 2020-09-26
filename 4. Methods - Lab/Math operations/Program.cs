using System;

namespace Math_operations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(MathOperations(num1, operation, num2)));
        }

        private static double MathOperations(double num1, char operatio, double num2)
        {
            double result = 0;
            if (operatio == '/')
            {
                result = Divide(num1, num2);
            }
            else if (operatio == '*')
            {
                result = Multiply(num1, num2);
            }
            else if (operatio == '+')
            {
                result = Add(num1, num2);
            }
            else
            {
                result = Substraction(num1, num2);
            }
            return result;
        }

        private static double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

        private static double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        private static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        private static double Substraction(double num1, double num2)
        {
            double result = (num1 - num2);
            return result;
        }
    }
}