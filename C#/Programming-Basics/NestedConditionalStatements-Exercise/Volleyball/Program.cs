using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double weekendsInSofia = 48 - weekends;
            double gamesInSofia = weekendsInSofia * (3.0 / 4);
            double gamesInBirthCity = weekends;
            double gamesInHolidayDay = holidays * (2.0 / 3);
            double games = gamesInSofia + gamesInHolidayDay + gamesInBirthCity;
            if (year == "leap")
            {
                double result = games + (games * 0.15);
                Console.WriteLine(Math.Truncate(result));
            }
            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(games));
            }
        }
    }
}
