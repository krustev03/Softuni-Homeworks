using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (projection == "premiere")
            {
                double result = (c * r) * 12.00;
                Console.WriteLine("{0:f2} leva", result);
            }
            if (projection == "normal")
            {
                double result = (c * r) * 7.50;
                Console.WriteLine("{0:f2} leva", result);
            }
            if (projection == "discount")
            {
                double result = (c * r) * 5.00;
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
