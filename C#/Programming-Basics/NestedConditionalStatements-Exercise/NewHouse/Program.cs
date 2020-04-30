using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int flowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            if (type == "Roses")
            {
                if (flowers > 80)
                {
                    double price = (flowers * 5) - ((flowers * 5) * 0.10);
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
                else
                {
                    double price = flowers * 5;
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
            }
            if (type == "Dahlias")
            {
                if (flowers > 90)
                {
                    double price = (flowers * 3.80) - ((flowers * 3.80) * 0.15);
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
                else
                {
                    double price = flowers * 3.80;
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
            }
            if (type == "Tulips")
            {
                if (flowers > 80)
                {
                    double price = (flowers * 2.80) - ((flowers * 2.80) * 0.15);
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
                else
                {
                    double price = flowers * 2.80;
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
            }
            if (type == "Narcissus")
            {
                if (flowers < 120)
                {
                    double price = (flowers * 3) + ((flowers * 3) * 0.15);
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
                else
                {
                    double price = flowers * 3;
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
            }
            if (type == "Gladiolus")
            {
                if (flowers < 80)
                {
                    double price = (flowers * 2.50) + ((flowers * 2.50) * 0.20);
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
                else
                {
                    double price = flowers * 2.50;
                    if (budget >= price)
                    {
                        Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:f2} leva left.", flowers, type, budget - price);
                    }
                    else
                    {
                        Console.WriteLine("Not enough money, you need {0:f2} leva more.", price - budget);
                    }
                }
            }
        }
    }
}
