using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());
            int timesSpend = 0;
            int days = 0;
            int count = 0;
            while (count == 0)
            {
                string does = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (does == "save")
                {
                    avaliableMoney += money;
                    if (avaliableMoney >= neededMoney)
                    {
                        count = 1;
                        Console.WriteLine("You saved the money for {0} days.", days);
                        break;
                    }
                    timesSpend = 0;
                }
                if (does == "spend")
                {
                    timesSpend++;
                    if (timesSpend == 5)
                    {
                        count = 1;
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                    avaliableMoney -= money;
                    if (money > avaliableMoney)
                    {
                        avaliableMoney = 0;
                    }
                }
            }
        }
    }
}
