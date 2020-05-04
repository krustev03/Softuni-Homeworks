using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string name = string.Empty;
            decimal allGrade = 0.0m;
            decimal allGradeForOne = 0.0m;
            decimal k = 0.0m;
            while (true)
            {
                name = Console.ReadLine();
                if (name == "Finish")
                {
                    break;
                }
                allGradeForOne = 0.0m;
                for (int i = 0; i < n; i++)
                {
                    decimal grade = decimal.Parse(Console.ReadLine());
                    allGrade += grade;
                    allGradeForOne += grade;
                    k++;
                }
                decimal averageGradeForOne = allGradeForOne / n;
                Console.WriteLine("{0} - {1:f2}.", name, averageGradeForOne);
            }
            decimal averageAllGrade = allGrade / k;
            Console.WriteLine("Student's final assessment is {0:f2}.", averageAllGrade);
        }
    }
}
