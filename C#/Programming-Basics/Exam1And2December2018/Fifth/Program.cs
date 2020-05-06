using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            var parts = int.Parse(Console.ReadLine());
            var moneyPrize = decimal.Parse(Console.ReadLine());
            int points = 0;
            for (int i = 1; i <= parts; i++)
            {
                int addPoints = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    points += addPoints;
                }
                if (i % 2 == 0)
                {
                    points += addPoints * 2;
                }
            }
            Console.WriteLine("The project prize was {0:f2} lv.", points * moneyPrize);
        }
    }
}
