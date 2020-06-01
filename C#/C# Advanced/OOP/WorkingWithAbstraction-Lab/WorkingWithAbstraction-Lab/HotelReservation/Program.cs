using System;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Season season = Enum.Parse<Season>(input[2]);

            decimal finalPrice = 0;

            if (input.Length == 4)
            {
                Discount discount = Enum.Parse<Discount>(input[3]);
                finalPrice = PriceCalculator.CalculatePrice(decimal.Parse(input[0]), int.Parse(input[1]), season, discount);
            }
            else
            {
                finalPrice = PriceCalculator.CalculatePriceWithoutDiscount(decimal.Parse(input[0]), int.Parse(input[1]), season);
            }
            

            Console.WriteLine($"{finalPrice:f2}");
        }
    }

    public enum Season
    {
        Spring = 2,
        Summer = 4,
        Autumn = 1,
        Winter = 3
    }

    public enum Discount
    {
        None,
        SecondVisit = 10,
        VIP = 20
    }
}
