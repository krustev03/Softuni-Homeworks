using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forth
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogFood = int.Parse(Console.ReadLine());
            double allGrams = 0;
            double dogFoodGrams = dogFood * 1000;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Adopted")
                {
                    break;
                }
                var gramsOfFood = int.Parse(input);
                allGrams += gramsOfFood;
            }

            if (dogFoodGrams >= allGrams)
            {
                Console.WriteLine("Food is enough! Leftovers: {0} grams.", dogFoodGrams - allGrams);
            }
            else
            {
                Console.WriteLine("Food is not enough. You need {0} grams more.", allGrams - dogFoodGrams);
            }
        }
    }
}
