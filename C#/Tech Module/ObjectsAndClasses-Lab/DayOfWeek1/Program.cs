using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            DateTime date = DateTime.ParseExact(str, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
