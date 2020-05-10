using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distance1 = GetDistance(x1, y1);
            double distance2 = GetDistance(x2, y2);
            if (distance1 >= distance2)
            {
                Console.WriteLine("(" + x2 + ", " + y2 + ")");
            }
            else
            {
                Console.WriteLine("(" + x1 + ", " + y1 + ")");
            }
        }
        static double GetDistance(double x, double y)
        {
            double distance = Math.Abs(x) + Math.Abs(y);
            return distance;
        }
    }
}
