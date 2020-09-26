using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool areChangesMade = false;

            string[] command = Console.ReadLine().Split();
            while (command[0] != "end")
            {
                List<int> result = new List<int>();

                if (command[0] == "Contains")
                {
                    if (numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command[0] == "PrintEven")
                {
                    List<int> evenNums = numbers.Where(cell => cell % 2 == 0).ToList();

                    Console.WriteLine(string.Join(' ', evenNums));
                }
                else if (command[0] == "PrintOdd")
                {
                    List<int> oddNums = numbers.Where(cell => cell % 2 == 1).ToList();
                    Console.WriteLine(string.Join(' ', oddNums));
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command[0] == "Filter")
                {
                    List<int> filter = numbers.Where(cell =>
                       {
                           switch (command[1])
                           {
                               case ">=":
                                   return cell >= int.Parse(command[2]);
                                   break;

                               case "<=":
                                   return cell <= int.Parse(command[2]);
                                   break;

                               case ">":
                                   return cell > int.Parse(command[2]);
                                   break;

                               case "<":
                                   return cell < int.Parse(command[2]);
                                   break;

                               default:
                                   return true;
                                   break;
                           }
                       }).ToList();
                    Console.WriteLine(string.Join(' ', filter));
                }
                else if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    areChangesMade = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    areChangesMade = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    areChangesMade = true;
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    areChangesMade = true;
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }

                command = Console.ReadLine().Split();
            }

            if (areChangesMade)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}