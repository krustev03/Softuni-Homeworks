using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var leftFood = int.Parse(Console.ReadLine());
            var dog1Food = double.Parse(Console.ReadLine());
            var dog2Food = double.Parse(Console.ReadLine());
            var dog3Food = double.Parse(Console.ReadLine());

            double dog1AllFood = dog1Food * days;
            double dog2AllFood = dog2Food * days;
            double dog3AllFood = dog3Food * days;
            double allFoodNeeded = dog2AllFood + dog1AllFood + dog3AllFood;

            if (allFoodNeeded <= leftFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(leftFood - allFoodNeeded));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allFoodNeeded - leftFood));
            }
        }
    }
}
