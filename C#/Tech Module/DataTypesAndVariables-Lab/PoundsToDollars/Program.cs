using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31m;
            Console.WriteLine("{0:f3}", dollars);
        }
    }
}
