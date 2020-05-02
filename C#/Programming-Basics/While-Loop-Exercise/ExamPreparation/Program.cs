using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            int numberOfPoorGrades = 0;
            double numberOfGrades = 0.0;
            double sumOfGrades = 0.0;
            string lastName = "";
            var input = Console.ReadLine();
            while (input != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numberOfPoorGrades++;
                }
                if (numberOfPoorGrades == poorGrades)
                {
                    Console.WriteLine("You need a break, {0} poor grades.", poorGrades);
                    break;
                }
                sumOfGrades += grade;
                numberOfGrades++;
                lastName = input;
                input = Console.ReadLine();
            }
            if (input == "Enough")
            {
                double average = sumOfGrades / numberOfGrades;
                Console.WriteLine("Average score: {0:f2}", average);
                Console.WriteLine("Number of problems: {0}", numberOfGrades);
                Console.WriteLine("Last problem: {0}", lastName);
            }
        }
    }
}
