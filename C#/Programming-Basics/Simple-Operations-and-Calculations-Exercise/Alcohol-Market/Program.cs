using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal whiskeyPrice = decimal.Parse(Console.ReadLine());
            decimal litersBeer = decimal.Parse(Console.ReadLine());
            decimal litersWine = decimal.Parse(Console.ReadLine());
            decimal litersRakia = decimal.Parse(Console.ReadLine());
            decimal litersWhiskey = decimal.Parse(Console.ReadLine());
            decimal rakiaPrice = whiskeyPrice / 2;
            decimal winePrice =  rakiaPrice - (rakiaPrice * 0.40m);
            decimal beerPrice = rakiaPrice - (rakiaPrice * 0.80m);
            decimal rakiaSum = rakiaPrice * litersRakia;
            decimal wineSum = winePrice * litersWine;
            decimal beerSum = beerPrice * litersBeer;
            decimal whiskeySum = whiskeyPrice * litersWhiskey;
            decimal finalPrice = whiskeySum + beerSum + wineSum + rakiaSum;
            Console.WriteLine(Math.Round(finalPrice, 2));
        }
    }
}
