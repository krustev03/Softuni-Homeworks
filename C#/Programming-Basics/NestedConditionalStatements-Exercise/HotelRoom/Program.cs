using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                double studio = 50.00;
                double apartment = 65.00;
                if (nights > 7 && nights <= 14)
                {
                    studio = studio - (studio * 0.05);
                }
                if (nights > 14)
                {
                    studio = studio - (studio * 0.30);
                    apartment = apartment - (apartment * 0.10);
                }
                double studioPrice = studio * nights;
                double apartmentPrice = apartment * nights;
                Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
            }
            if (month == "June" || month == "September")
            {
                double studio = 75.20;
                double apartment = 68.70;
                if (nights > 14)
                {
                    studio = studio - (studio * 0.20);
                    apartment = apartment - (apartment * 0.10);
                }
                double studioPrice = studio * nights;
                double apartmentPrice = apartment * nights;
                Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
            }
            if (month == "July" || month == "August")
            {
                double studio = 76.00;
                double apartment = 77.00;
                if (nights > 14)
                {
                    apartment = apartment - (apartment * 0.10);
                }
                double studioPrice = studio * nights;
                double apartmentPrice = apartment * nights;
                Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
                Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
            }
        }
    }
}
