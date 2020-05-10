using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            double result = GetFactorial(num1) / GetFactorial(num2);
            Console.WriteLine("{0:f2}", result);
        }
        static double GetFactorial(long num)
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * GetFactorial(num - 1);
            }
        }
    }
}
