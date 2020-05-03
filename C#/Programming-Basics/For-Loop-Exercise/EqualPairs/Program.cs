using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            double diff = 0;
            double maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                var num1 = double.Parse(Console.ReadLine());
                var num2 = double.Parse(Console.ReadLine());
                if (i != 0)
                {
                    diff = Math.Abs((num1 + num2) - sum);
                }
                if (diff >= Math.Abs(((num1 + num2) - sum)))
                {
                    maxDiff = diff;
                }
                sum = num1 + num2;
            }
            if (maxDiff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
        }
    }
}
