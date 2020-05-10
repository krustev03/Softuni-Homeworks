using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            double result = PowNumber(num, pow);
            Console.WriteLine(result);
        }
        static double PowNumber(double num, int pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
