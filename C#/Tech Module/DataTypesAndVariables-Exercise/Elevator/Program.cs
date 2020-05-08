using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int fullCourses = people / capacity;
            if (capacity > people)
            {
                Console.WriteLine(1);
            }
            else 
            {
                people = people - (fullCourses * capacity);
                if (people == 0)
                {
                    Console.WriteLine(fullCourses);
                }
                else
                {
                    Console.WriteLine(fullCourses + 1);
                }
            }
        }
    }
}
