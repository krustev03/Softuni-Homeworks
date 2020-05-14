using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] parts = command.Split(" : ").ToArray();
                string course = parts[0];
                string student = parts[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course,  new List<string>() );
                    courses[course].Add(student);
                }
                else
                {
                    courses[course].Add(student);
                }
                
            }
            
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");
                List<string> orderedNames = item.Value.ToList();
                orderedNames.Sort();
                for (int i = 0; i < orderedNames.Count; i++)
                {
                    Console.WriteLine($"-- {orderedNames[i]}");
                }
            }
        }
    }
}
