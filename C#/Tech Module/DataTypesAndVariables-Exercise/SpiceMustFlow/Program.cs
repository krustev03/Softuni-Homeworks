using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            long yield = long.Parse(Console.ReadLine());
            long total = 0;
            int days = 0;
            if (yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                while (yield >= 100)
                {
                    total = total + (yield - 26);
                    yield -= 10;
                    days++;
                }
                total -= 26;
                Console.WriteLine(days);
                Console.WriteLine(total);
            }
        }
    }
}
