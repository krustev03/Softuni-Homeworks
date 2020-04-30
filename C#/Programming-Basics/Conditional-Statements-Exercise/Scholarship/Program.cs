using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var income = double.Parse(Console.ReadLine());
            var grade = double.Parse(Console.ReadLine());
            var minimumSalary = double.Parse(Console.ReadLine());
            double socialScholarship = 0;
            double schoolScholarship = 0;

            if (income < minimumSalary && grade > 4.50)
            {
                socialScholarship = minimumSalary * 0.35;
            }
            if (grade >= 5.50)
            {
                schoolScholarship = grade * 25;
            }
            if (socialScholarship == 0 && schoolScholarship == 0)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (socialScholarship > schoolScholarship)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialScholarship));
            }
            else if (socialScholarship <= schoolScholarship)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(schoolScholarship));
            }
        }
    }
}
