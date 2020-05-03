﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                if (num >= 800)
                {
                    p5++;
                }
            }

            double p1Percent = p1 / n * 100.0;
            double p2Percent = p2 / n * 100.0;
            double p3Percent = p3 / n * 100.0;
            double p4Percent = p4 / n * 100.0;
            double p5Percent = p5 / n * 100.0;

            Console.WriteLine("{0:f2}%", p1Percent);
            Console.WriteLine("{0:f2}%", p2Percent);
            Console.WriteLine("{0:f2}%", p3Percent);
            Console.WriteLine("{0:f2}%", p4Percent);
            Console.WriteLine("{0:f2}%", p5Percent);
        }
    }
}
