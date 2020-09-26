using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string companyName = input[0];
            Dictionary<string, List<string>> companyWithId = new Dictionary<string, List<string>>();

            while (companyName != "End")
            {
                string id = input[1];
                List<string> ids = new List<string>();

                if (!companyWithId.ContainsKey(companyName))
                {
                    ids.Add(id);
                    companyWithId.Add(companyName, ids);
                }
                else if (companyWithId.ContainsKey(companyName) && !companyWithId[companyName].Contains(id))
                {
                    companyWithId[companyName].Add(id);
                }

                input = Console.ReadLine().Split(" -> ");
                companyName = input[0];
            }

            foreach (var company in companyWithId.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}