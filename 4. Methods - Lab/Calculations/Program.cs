using System;

namespace Calculations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            OperationWihtNumbers(operation, firstNum, secondNum);
        }

        private static void OperationWihtNumbers(string operation, double firstNum, double secondNum)
        {
            if (operation == "add")
            {
                AddNumbers(firstNum, secondNum);
            }
            else if (operation == "multiply")
            {
                MultiplyNumbers(firstNum, secondNum);
            }
            else if (operation == "subtract")
            {
                SubstractNumbers(firstNum, secondNum);
            }
            else
            {
                DivideNumbers(firstNum, secondNum);
            }
        }

        private static void AddNumbers(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine(result);
        }

        private static void MultiplyNumbers(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine(result);
        }

        private static void SubstractNumbers(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine(result);
        }

        private static void DivideNumbers(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}