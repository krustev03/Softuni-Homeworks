using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1++;
                }
                if (num % 3 == 0)
                {
                    p2++;
                }
                if (num % 4 == 0)
                {
                    p3++;
                }
            }
            double p1Percent = p1 / n * 100.0;
            double p2Percent = p2 / n * 100.0;
            double p3Percent = p3 / n * 100.0;

            Console.WriteLine("{0:f2}%", p1Percent);
            Console.WriteLine("{0:f2}%", p2Percent);
            Console.WriteLine("{0:f2}%", p3Percent);
        }
    }
}
