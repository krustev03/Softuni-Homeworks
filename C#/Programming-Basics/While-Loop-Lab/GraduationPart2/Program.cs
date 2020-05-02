using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0.0;
            double counter = 1;
            double stop = 0;
            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                }
                else
                {
                    stop++;
                }
                if (stop == 2)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade", name, counter - 1);
                    break;
                }
                if (counter == 12)
                {
                    double average = sum / 12.0;
                    Console.WriteLine("{0} graduated. Average grade: {1:f2}", name, average);
                }
                counter++;
            }
        }
    }
}
