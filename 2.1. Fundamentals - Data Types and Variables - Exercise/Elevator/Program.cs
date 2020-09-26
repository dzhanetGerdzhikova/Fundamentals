using System;

namespace Elevator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int count = 0;
            while (people > 0)
            {
                people -= capacity;
                count++;
            }
            Console.WriteLine(count);

            //int countCourses = 0;

            //if (people % capacity == 0)
            //{
            //    countCourses = people / capacity;
            //}
            //else if (people % capacity != 0)
            //{
            //    countCourses = people / capacity;
            //    countCourses++;
            //}
            //Console.WriteLine(countCourses);
        }
    }
}