using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasSpirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int ornamentSet = 2;
            int treeSkirt = 5;
            int treeGarlands = 3;
            int treeLights = 15;
            int spirit = 0;
            int price = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 11 == 0)
                {
                    quantity = quantity + 2;
                }
                if (i % 2 == 0)
                {
                    price = price + (ornamentSet * quantity);
                    spirit += 5;
                }
                if (i % 3 == 0)
                {
                    price = price + (treeGarlands * quantity + treeSkirt * quantity);
                    spirit += 13;
                }
                if (i % 5 == 0)
                {
                    price = price + (treeLights * quantity);
                    spirit += 17;
                }
                if (i % 15 == 0)
                {
                    spirit += 30;
                }
                if (i % 10 == 0)
                {
                    spirit -= 20;
                    price = price + (treeSkirt + treeLights + treeGarlands);
                }
                
                if (i == days && i % 10 == 0)
                {
                    spirit -= 30;
                }
            }
            Console.WriteLine($"Total cost: {price}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
