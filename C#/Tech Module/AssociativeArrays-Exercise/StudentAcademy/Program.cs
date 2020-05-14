using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);
            }
            Dictionary<string, double> filteredStudents = new Dictionary<string, double>();
            foreach (var student in students)
            {
                double grade = student.Value.Sum() / student.Value.Count;
                if (grade >= 4.50)
                {
                    filteredStudents.Add(student.Key, grade);
                }
            }
            
            foreach (var item in filteredStudents.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
            }
        }
    }
}
