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
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] info = command.Split().ToArray();
                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string town = info[3];
                Student student = new Student();
                student.firstName = firstName;
                student.lastName = lastName;
                student.age = age;
                student.town = town;
                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student student1 = GetStudent(students, firstName, lastName);
                    student1.firstName = firstName;
                    student1.lastName = lastName;
                    student1.age = age;
                    student1.town = town;
                }
                else
                {
                    Student student1 = new Student()
                    {
                        firstName = firstName,
                        lastName = lastName,
                        age = age,
                        town = town
                    };

                    students.Add(student1);
                }

            }
            string filterTown = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.town == filterTown)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }
    }
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string town { get; set; }
    }
}
