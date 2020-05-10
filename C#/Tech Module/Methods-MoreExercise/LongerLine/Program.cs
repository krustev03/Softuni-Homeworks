using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1One = double.Parse(Console.ReadLine());
            double y1One = double.Parse(Console.ReadLine());
            double x2One = double.Parse(Console.ReadLine());
            double y2One = double.Parse(Console.ReadLine());
            double x1Two = double.Parse(Console.ReadLine());
            double y1Two = double.Parse(Console.ReadLine());
            double x2Two = double.Parse(Console.ReadLine());
            double y2Two = double.Parse(Console.ReadLine());
            double lineOne = GetDistance(x1One, y1One) + GetDistance(x2One, y2One);
            double lineTwo = GetDistance(x1Two, y1Two) + GetDistance(x2Two, y2Two);
            if (lineOne >= lineTwo)
            {
                if (GetDistance(x1One, y1One) > GetDistance(x2One, y2One))
                {
                    Console.WriteLine("(" + x2One + ", " + y2One + ")" + "(" + x1One + ", " + y1One + ")");
                }
                else
                {
                    Console.WriteLine("(" + x1One + ", " + y1One + ")" + "(" + x2One + ", " + y2One + ")");
                }
            }
            else
            {
                if (GetDistance(x1Two, y1Two) > GetDistance(x2Two, y2Two))
                {
                    Console.WriteLine("(" + x2Two + ", " + y2Two + ")" + "(" + x1Two + ", " + y1Two + ")");
                }
                else
                {
                    Console.WriteLine("(" + x1Two + ", " + y1Two + ")" + "(" + x2Two + ", " + y2Two + ")");
                }
            }
        }
        static double GetDistance(double x, double y)
        {
            double distance = Math.Abs(x) + Math.Abs(y);
            return distance;
        }
    }
}
