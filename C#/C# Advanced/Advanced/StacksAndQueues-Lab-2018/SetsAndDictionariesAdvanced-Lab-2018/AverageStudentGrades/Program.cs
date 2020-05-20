using System;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }

            foreach (var item in students)
            {
                var grades = item.Value.ToArray();
                double sum = 0;
                string gradesRounded = string.Empty;

                for (int i = 0; i < grades.Length; i++)
                {
                    gradesRounded += $"{grades[i]:F2} ";
                    sum += grades[i];
                }

                
                Console.WriteLine($"{item.Key} -> {gradesRounded}(avg: {(sum / grades.Length):F2})");
            }
        }
    }
}
