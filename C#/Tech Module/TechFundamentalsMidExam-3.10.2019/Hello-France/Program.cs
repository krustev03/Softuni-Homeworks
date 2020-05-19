using System;
using System.Collections.Generic;
using System.Linq;

namespace Hello_France
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            List<decimal> newPrices = new List<decimal>();
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal clothesMax = 50.00m;
            decimal shoesMax = 35.00m;
            decimal accessoriesMax = 20.50m;
            decimal sum = 0.0m; ;
            decimal newSum = 0.0m;
            for (int i = 0; i < items.Count; i++)
            {
                string[] parts = items[i].Split("->").ToArray();
                if (parts[0] == "Clothes")
                {
                    decimal price = decimal.Parse(parts[1]);
                    if (price <= clothesMax && budget >= price)
                    {
                        budget = budget - price;
                        newPrices.Add(price);
                        sum += price;
                    }
                }
                if (parts[0] == "Shoes")
                {
                    decimal price = decimal.Parse(parts[1]);
                    if (price <= shoesMax && budget >= price)
                    {
                        budget = budget - price;
                        newPrices.Add(price);
                        sum += price;
                    }
                }
                if (parts[0] == "Accessories")
                {
                    decimal price = decimal.Parse(parts[1]);
                    if (price <= accessoriesMax && budget >= price)
                    {
                        budget = budget - price;
                        newPrices.Add(price);
                        sum += price;
                    }
                }
            }
            for (int i = 0; i < newPrices.Count; i++)
            {
                newPrices[i] = newPrices[i] + (newPrices[i] * 0.40m);
                newSum += newPrices[i];
                Console.Write("{0:f2} ", newPrices[i]);
            }
            Console.WriteLine();
            decimal profit = newSum - sum;
            Console.WriteLine("Profit: {0:f2}", profit);
            decimal allMoney = budget + newSum;
            if (allMoney >= 150.00m)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
