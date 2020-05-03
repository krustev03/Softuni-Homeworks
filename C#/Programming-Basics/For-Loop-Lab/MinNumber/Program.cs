using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double min = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
