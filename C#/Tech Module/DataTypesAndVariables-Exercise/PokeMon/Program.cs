using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count = 0;
            double NDivideByTwo = n / 2.0;
            
            while (n >= m)
            {
                if (NDivideByTwo == n)
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                    if (n >= m)
                    {
                        n = n - m;
                        count++;
                    }
                }
                else
                {
                    n = n - m;
                    count++;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
