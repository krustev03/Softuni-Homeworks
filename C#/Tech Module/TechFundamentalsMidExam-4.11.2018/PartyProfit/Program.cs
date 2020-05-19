using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                coins = (coins + 50) - (partySize * 2);
                if (i % 3 == 0)
                {
                    coins = coins - (partySize * 3);
                }
                if (i % 5 == 0)
                {
                    coins = coins + (partySize * 20);
                    if (i % 15 == 0)
                    {
                        coins = coins - (partySize * 2);
                    }
                }
            }
            double coinsForOne = coins / partySize;
            Console.WriteLine($"{partySize} companions received {Math.Floor(coinsForOne)} coins each.");
        }
    }
}
