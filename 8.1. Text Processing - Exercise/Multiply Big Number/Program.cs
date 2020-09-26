using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();

            int ostatyk = 0;
            for (int i = first.Length - 1; i >= 0; i--)
            {
                int currentResult = int.Parse(first[i].ToString()) * second;//8 //2
                currentResult += ostatyk;

                if (currentResult >= 10)
                {
                    char lastSymbol = currentResult.ToString()[1];
                    result.Append(lastSymbol);

                    char firstSymbol = currentResult.ToString()[0];
                    ostatyk = int.Parse(firstSymbol.ToString());
                    if (i == 0)
                    {
                        result.Append(ostatyk);
                    }
                }
                else
                {
                    result.Append(currentResult);
                    ostatyk = 0;
                }
            }
            Console.WriteLine(string.Join("", result.ToString().Reverse()).TrimStart('0'));
        }
    }
}