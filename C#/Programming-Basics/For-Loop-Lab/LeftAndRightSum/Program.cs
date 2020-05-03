using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum1 = 0;
            double sum2 = 0;

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum1 += num;
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum2 += num;
            }

            Console.WriteLine();

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            { 
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
