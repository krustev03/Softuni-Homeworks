﻿namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        private Dictionary<string, Student> repo;

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo
        {
            get { return repo; }
            private set { repo = value; }
        }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                Create(args[1], int.Parse(args[2]), double.Parse(args[3]));
            }
            else if (args[0] == "Show")
            {
                Show(args[1]);
            }
            else if (args[0] == "Exit")
            {
                Exit();
            }
        }

        public void Create(string name, int age, double grade)
        {
            if (!repo.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Repo[name] = student;
            }
        }

        public void Show(string name)
        {
            if (Repo.ContainsKey(name))
            {
                var student = Repo[name];
                string view = $"{student.Name} is {student.Age} years old.";

                if (student.Grade >= 5.00)
                {
                    view += " Excellent student.";
                }
                else if (student.Grade < 5.00 && student.Grade >= 3.50)
                {
                    view += " Average student.";
                }
                else
                {
                    view += " Very nice person.";
                }

                Console.WriteLine(view);
            }
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }

    public class Student
    {
        private string name;
        private int age;
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.grade = grade;
        }
    }
}