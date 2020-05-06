using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            decimal money = 0.0m; 
            days--;
            if (type == "room for one person")
            {
                money = days * 18.00m;
            }
            if (type == "apartment")
            {
                money = days * 25.00m;
                if (days < 10)
                {
                    money = money - (money * 0.30m);
                }
                if (days >= 10 && days <= 15)
                {
                    money = money - (money * 0.35m);
                }
                if (days > 15)
                {
                    money = money - (money * 0.50m);
                }
            }
            if (type == "president apartment")
            {
                money = days * 35.00m;
                if (days < 10)
                {
                    money = money - (money * 0.10m);
                }
                if (days >= 10 && days <= 15)
                {
                    money = money - (money * 0.15m);
                }
                if (days > 15)
                {
                    money = money - (money * 0.20m);
                }
            }
            if (grade == "positive")
            {
                money = money + (money * 0.25m);
            }
            if (grade == "negative")
            {
                money = money - (money * 0.10m);
            }
            Console.WriteLine(Math.Round(money, 2));
        }
    }
}
