using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            double sum = 0;
            double normal = 249.99;
            double vip = 499.99;
            
            if (category == "normal")
            {
                if (people >= 1 && people <= 4) { sum = 0.75; }
                else if (people >= 5 && people <= 9) { sum = 0.60; }
                else if (people >= 10 && people <= 24) { sum = 0.50; }
                else if (people >= 25 && people <= 49) { sum = 0.40; }
                else if (people > 49) { sum = 0.25; }
                double allSum = ((sum * budget) + (people * normal));
                if (budget >= allSum )
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budget - allSum);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allSum - budget));
                }
            }
            if (category == "vip")
            {
                if (people >= 1 && people <= 4) { sum = 0.75; }
                else if (people >= 5 && people <= 9) { sum = 0.60; }
                else if (people >= 10 && people <= 24) { sum = 0.50; }
                else if (people >= 25 && people <= 49) { sum = 0.40; }
                else if (people > 49) { sum = 0.25; }
                double allSum = ((sum * budget) + (people * vip));
                if (budget >= allSum)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", budget - allSum);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(allSum - budget));
                }
            }
        }
    }
}
