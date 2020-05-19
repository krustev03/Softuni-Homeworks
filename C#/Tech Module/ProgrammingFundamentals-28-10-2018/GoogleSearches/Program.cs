using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleSearches
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int numOfUsers = int.Parse(Console.ReadLine());
            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());
            decimal sum = 0.0m;
            for (int i = 1; i <= numOfUsers; i++)
            {
                int words = int.Parse(Console.ReadLine());
                if (!(words > 5) && !(words == 1)) 
                {
                    if (i % 3 == 0)
                    {
                        sum = sum + (3 * moneyPerSearch);
                    }
                    else
                    {
                        sum += moneyPerSearch;
                    }
                }
                if (words == 1)
                {
                    if (i % 3 == 0)
                    {
                        sum = sum + (3 * (2 * moneyPerSearch));
                    }
                    else
                    {
                        sum =  sum + (moneyPerSearch * 2);
                    }
                }
            }
            Console.WriteLine("Total money earned for {0} days: {1:f2}", days, sum * days);
        }
    }
}
