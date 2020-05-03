using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washingMachine = decimal.Parse(Console.ReadLine());
            var priceForToy = decimal.Parse(Console.ReadLine());
            decimal check = 0;
            decimal moneyGiven = 0;
            int toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toys++;
                }
                if (i % 2  == 0)
                {
                    check += 10;
                    moneyGiven += check - 1;
                }
            }

            decimal allMoney = moneyGiven + (toys * priceForToy);
            if (allMoney >= washingMachine)
            {
                Console.WriteLine("Yes! {0:f2}", allMoney - washingMachine);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMachine - allMoney);
            }
        }
    }
}
