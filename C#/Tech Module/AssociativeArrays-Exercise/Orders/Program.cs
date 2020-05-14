using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "buy")
                {
                    break;
                }
                string[] parts = command.Split();
                string product = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                if (!productsPrice.ContainsKey(product))
                {
                    productsPrice.Add(product, 0);
                    productsQuantity.Add(product, 0);
                }
                productsPrice[product] = price;
                productsQuantity[product] += quantity;
            }
            var prices = productsPrice.Values.ToList();
            var names = productsQuantity.Keys.ToList();
            var quantities = productsQuantity.Values.ToList();
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{names[i]} -> {prices[i] * quantities[i]}");
            }
        }
    }
}
