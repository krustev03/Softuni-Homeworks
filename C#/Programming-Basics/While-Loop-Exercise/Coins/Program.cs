using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int coins = 0;
            money = money * 100;
            while (money != 0)
            {
                if (money >= 200)
                {
                    coins += (int)money / 200;
                    money = money % 200;
                }
                else if (money >= 100)
                {
                    coins += (int)money / 100;
                    money = money % 100;
                }
                else if (money >= 50)
                {
                    coins += (int)money / 50;
                    money = money % 50;
                }
                else if (money >= 20)
                {
                    coins += (int)money / 20;
                    money = money % 20;
                }
                else if (money >= 10)
                {
                    coins += (int)money / 10;
                    money = money % 10;
                }
                else if (money >= 5)
                {
                    coins += (int)money / 5;
                    money = money % 5;
                }
                else if (money >= 2)
                {
                    coins += (int)money / 2;
                    money = money % 2;
                }
                else if (money >= 1)
                {
                    coins += (int)money / 1;
                    money = money % 1;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
