using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Students
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countOfStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOfStudent; i++)
            {
                string[] informationOfStudent = Console.ReadLine().Split(' ');
                string firstName = informationOfStudent[0];
                string lastName = informationOfStudent[1];
                double grade = double.Parse(informationOfStudent[2]);

                students.Add(new Student(firstName, lastName, grade));
            }
            students = students.OrderByDescending(e => e.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    internal class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}