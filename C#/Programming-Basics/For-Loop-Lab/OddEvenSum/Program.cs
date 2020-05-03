using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sumEven = 0;
            double sumOdd = 0;

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                if (i % 2 != 0)
                {
                    sumOdd += num;
                }
            }

            Console.WriteLine();

            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", sumEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(sumEven - sumOdd));
            }
        }
    }
}
