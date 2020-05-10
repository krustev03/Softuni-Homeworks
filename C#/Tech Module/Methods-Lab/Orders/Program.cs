using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculatePrice(product, quantity);
        }
        static void CalculatePrice(string product, int quantity)
        {
            decimal price = 0.0m;
            switch (product)
            {
                case "coffee": price = 1.50m; break;
                case "water": price = 1.00m; break;
                case "coke": price = 1.40m; break;
                case "snacks": price = 2.00m; break;
            }
            Console.WriteLine("{0:f2}", price * quantity);
        }
    }
}
