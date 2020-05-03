using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
