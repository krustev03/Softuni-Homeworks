using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            double days = years * 365.2422;
            int hours = (int)days * 24;
            long minutes = hours * 60;
            Console.WriteLine($"{centuries} centuries = {years} years = {(int)days} days = {hours} hours = {minutes} minutes");
        }
    }
}
