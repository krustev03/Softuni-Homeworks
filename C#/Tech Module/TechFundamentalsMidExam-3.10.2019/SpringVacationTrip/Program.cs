using System;

namespace SpringVacationTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int group = int.Parse(Console.ReadLine());
            decimal fuelPerKm = decimal.Parse(Console.ReadLine());
            decimal foodExpensesPerPerson = decimal.Parse(Console.ReadLine());
            decimal priceForRoom = decimal.Parse(Console.ReadLine());
            decimal foodExpenses = days * group * foodExpensesPerPerson;
            decimal hotelExpenses = days * group * priceForRoom;
            if (group > 10)
            {
                hotelExpenses = hotelExpenses - (hotelExpenses * 0.25m);
            }
            decimal currentExpenses = hotelExpenses + foodExpenses;
            int k = 0;
            for (int i = 1; i <= days; i++)
            {
                if (currentExpenses > budget)
                {
                    Console.WriteLine("Not enough money to continue the trip. You need {0:f2}$ more.", currentExpenses - budget);
                    k = 1;
                    break;
                }
                decimal travelKm = decimal.Parse(Console.ReadLine());
                decimal travelExpenses = travelKm * fuelPerKm;
                currentExpenses = currentExpenses + travelExpenses;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses = currentExpenses + (currentExpenses * 0.40m);
                }
                if (currentExpenses > budget)
                {
                    Console.WriteLine("Not enough money to continue the trip. You need {0:f2}$ more.", currentExpenses - budget);
                    k = 1;
                    break;
                }
                if (i % 7 == 0)
                {
                    currentExpenses = currentExpenses - (currentExpenses / group);
                }
            }
            if (k == 0)
            {
                Console.WriteLine("You have reached the destination. You have {0:f2}$ budget left.", budget - currentExpenses);
            }
        }
    }
}
