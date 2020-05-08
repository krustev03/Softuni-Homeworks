using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = decimal.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000.0m;
            Console.WriteLine("{0:f2}", kilometers);
        }
    }
}
