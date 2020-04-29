using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bg = usd * 1.79549m;
            Console.WriteLine(Math.Round(bg, 2) + " BGN");
        }
    }
}
