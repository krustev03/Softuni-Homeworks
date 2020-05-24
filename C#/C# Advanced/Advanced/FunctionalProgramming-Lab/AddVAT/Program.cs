using System;
using System.Linq;
using System.Collections.Generic;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, double> parser = n => double.Parse(n);
            double[] numbers = input.Split(new string[] { ", " },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Select(n => n * 1.2)
                .ToArray();
            foreach (var price in numbers)
            {
                Console.WriteLine($"{price:f2}");
            }
            
        }
    }
}
