using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation
{
    public class PriceCalculator
    {
        public static decimal CalculatePrice(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        { 
            int multiplier = (int)season;

            decimal discountMultiplier = (decimal)discount / 100;

            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;

            decimal discountedAmount = priceBeforeDiscount * discountMultiplier;

            decimal finalPrice = priceBeforeDiscount - discountedAmount;

            return finalPrice;
        }

        public static decimal CalculatePriceWithoutDiscount(decimal pricePerDay, int numberOfDays, Season season)
        {
            int multiplier = (int)season;

            decimal finalPrice = numberOfDays * pricePerDay * multiplier;
            
            return finalPrice;
        }
    }
}
