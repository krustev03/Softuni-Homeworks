using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal fishermanMoney = 0.0m;
            decimal moneyToPay = 0.0m;
            int k = 0;
            for (int r = 1; r <= n; r++)
            {
                string nameOfFish = Console.ReadLine();
                if (nameOfFish == "Stop")
                {
                    break;
                }
                decimal sumFish = 0.0m;
                decimal kilograms = decimal.Parse(Console.ReadLine());
                for (int i = 0; i < nameOfFish.Length; i++)
                {
                    sumFish += (int)nameOfFish[i];
                }
                decimal fishPrice = sumFish / kilograms;
                if (r % 3 == 0)
                {
                    fishermanMoney += fishPrice;
                }
                if (r % 3 != 0)
                {
                    moneyToPay += fishPrice;
                }
                k++;
            }
            if (k == n)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }
            if (moneyToPay > fishermanMoney)
            {
                Console.WriteLine("Lyubo lost {0:f2} leva today.", moneyToPay - fishermanMoney);
            }
            if (fishermanMoney >= moneyToPay)
            {
                Console.WriteLine("Lyubo's profit from {0} fishes is {1:f2} leva.", k, fishermanMoney - moneyToPay);
            }
        }
    }
}
