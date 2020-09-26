using System;
using System.Collections.Generic;
using System.Linq;

namespace Student_Academy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsWithGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < countInput; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsWithGrade.ContainsKey(name))
                {
                    List<double> totalSumOfGrade = new List<double>();
                    totalSumOfGrade.Add(grade);
                    studentsWithGrade.Add(name, totalSumOfGrade);
                }
                else
                {
                    studentsWithGrade[name].Add(grade);
                }
            }

            foreach (var kvp in studentsWithGrade.Where(e => e.Value.Average() >= 4.5).OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}