using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);

            double P = 2 * (x + y);
            double S = x * y;

            Console.WriteLine(S);
            Console.WriteLine(P);
        }
    }
}
