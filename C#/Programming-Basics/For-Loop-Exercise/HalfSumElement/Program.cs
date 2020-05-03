using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sum = 0;
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            sum -= max;
            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sum - max));
            }
        }
    }
}
