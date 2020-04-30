using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string type = "";
            string destination = "";
            double paid = 0;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    paid = budget * 0.30;
                }
                if (season == "winter")
                {
                    type = "Hotel";
                    paid = budget * 0.70;
                }
            }
            if (budget <= 1000 && budget > 100)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    paid = budget * 0.40;
                }
                if (season == "winter")
                {
                    type = "Hotel";
                    paid = budget * 0.80;
                }
            }
            if (budget > 1000)
            {
                destination = "Europe";
                type = "Hotel";
                paid = budget * 0.90;
            }
            Console.WriteLine("Somewhere in {0}", destination);
            Console.WriteLine("{0} - {1:f2}", type, paid);
        }
    }
}
