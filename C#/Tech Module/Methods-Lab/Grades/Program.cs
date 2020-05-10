﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }
        static void PrintGrade(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            if (grade >= 3.00 && grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            if (grade >= 3.50 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
