using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int k = 0;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if ((a < b && b < c) && a + b + c == n)
                        {
                            Console.WriteLine($"{a} + {b} + {c} = {n}");
                            k = 1;
                        }
                        if ((a > b && b > c) && a * b * c == n)
                        {
                            Console.WriteLine($"{a} * {b} * {c} = {n}");
                            k = 1;
                        }
                    }
                }
            }
            if (k == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
