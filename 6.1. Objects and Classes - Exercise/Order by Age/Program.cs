using System;
using System.Collections.Generic;
using System.Linq;

namespace Order_by_Age
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string nameOfPerson = input[0];

            List<Person> persons = new List<Person>();

            while (input[0] != "End")
            {
                string idOfPerson = input[1];
                int ageOfPerson = int.Parse(input[2]);
                persons.Add(new Person(nameOfPerson, idOfPerson, ageOfPerson));

                input = Console.ReadLine().Split();
                nameOfPerson = input[0];
            }
            persons = persons.OrderBy(e => e.AgeOfPerson).ToList();

            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.NameOfPerson} with ID: {person.IdOfPerson} is {person.AgeOfPerson} years old.");
            }
        }
    }

    internal class Person
    {
        public Person(string name, string id, int age)
        {
            this.NameOfPerson = name;
            this.IdOfPerson = id;
            this.AgeOfPerson = age;
        }

        public string NameOfPerson { get; set; }
        public string IdOfPerson { get; set; }
        public int AgeOfPerson { get; set; }
    }
}