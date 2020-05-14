using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] parts = command.Split(" -> ").ToArray();
                string company = parts[0];
                string id = parts[1];
                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(id);
                }
                else
                {
                    if (!companies[company].Contains(id))
                    {
                        companies[company].Add(id);
                    }
                }
            }
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var user in companies[item.Key])
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    } 
}
