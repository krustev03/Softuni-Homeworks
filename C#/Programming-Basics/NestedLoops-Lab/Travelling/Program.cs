using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string country = Console.ReadLine();
                if (country == "End")
                {
                    break;
                }
                decimal minimalBudget = decimal.Parse(Console.ReadLine());
                while (minimalBudget > 0)
                {
                    decimal sum = decimal.Parse(Console.ReadLine());
                    minimalBudget -= sum;
                }
                Console.WriteLine("Going to {0}!", country);
            }
        }
    }
}
