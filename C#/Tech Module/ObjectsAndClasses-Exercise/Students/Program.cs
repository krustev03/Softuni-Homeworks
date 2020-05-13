using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> parts = Console.ReadLine().Split().ToList();
                double grade = double.Parse(parts[2]);
                var student = new Student(parts[0], parts[1], grade);
                students.Add(student);
            }
            students = students.OrderByDescending(x => x.grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1}: {2:f2}", student.firstName, student.lastName, student.grade);
            }
        }
    }
    class Student
    {
        public Student(string first, string last, double gradeOf)
        {
            firstName = first;
            lastName = last;
            grade = gradeOf;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double grade { get; set; }
    }
}
