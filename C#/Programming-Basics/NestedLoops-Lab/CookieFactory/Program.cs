using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfProducts = int.Parse(Console.ReadLine());
            string type = string.Empty;
            bool sugar = false;
            bool eggs = false;
            bool flour = false;
            for (int i = 1; i <= numOfProducts; i++)
            {
                sugar = false;
                eggs = false;
                flour = false;
                type = string.Empty;

                while (true)
                {
                    type = Console.ReadLine();
                    if (type == "sugar")
                    {
                        sugar = true;
                    }
                    if (type == "eggs")
                    {
                        eggs = true;
                    }
                    if (type == "flour")
                    {
                        flour = true;
                    }
                    if (type == "Bake!")
                    {
                        if (sugar == false || eggs == false || flour == false)
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                        if (sugar == true && eggs == true && flour == true)
                        {
                            Console.WriteLine("Baking batch number {0}...", i);
                            break;
                        }
                    }
                }
            }
        }
    }
}
