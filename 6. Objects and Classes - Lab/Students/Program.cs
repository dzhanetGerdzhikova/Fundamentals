using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] studentsInfo = Console.ReadLine().Split();
            List<Student> students = new List<Student>();

            while (studentsInfo[0] != "end")
            {
                students.Add(new Student(studentsInfo[0], studentsInfo[1], int.Parse(studentsInfo[2]), studentsInfo[3]));

                studentsInfo = Console.ReadLine().Split();
            }
            string town = Console.ReadLine();

            students = students.Where(e => e.HomeTown == town).ToList();

            //Console.WriteLine(string.Join("\n", students.Select(e => $"{e.FirstName} {e.LastName} is {e.Age} years old.")));
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    internal class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}