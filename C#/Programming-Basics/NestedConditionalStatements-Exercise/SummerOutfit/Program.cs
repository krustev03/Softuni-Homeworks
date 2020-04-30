using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine().ToLower();

            if (10 <= degrees && degrees <= 18)
            {
                if (partOfDay == "morning")
                {
                    Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers.", degrees);
                }
                else if (partOfDay == "afternoon")
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (partOfDay == "evening")
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
            }
            else if (18 < degrees && degrees <= 24)
            {
                if (partOfDay == "morning")
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (partOfDay == "afternoon")
                {
                    Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                }
                else if (partOfDay == "evening")
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
            }
            else if (25 <= degrees)
            {
                if (partOfDay == "morning")
                {
                    Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                }
                else if (partOfDay == "afternoon")
                {
                    Console.WriteLine("It's {0} degrees, get your Swim Suit and Barefoot.", degrees);
                }
                else if (partOfDay == "evening")
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
            }
        }
    }
}
