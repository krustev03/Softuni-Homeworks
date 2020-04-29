using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sweeters = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofrets = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            decimal cakesSum = cakes * 45;
            decimal gofretsSum = gofrets * 5.80m;
            decimal pancakesSum = pancakes * 3.20m;
            decimal sumForOneDay = (cakesSum + gofretsSum + pancakesSum) * sweeters;
            decimal sumForAllCampany = sumForOneDay * days;
            decimal sumAfterPay = sumForAllCampany - (sumForAllCampany / 8);
            Console.WriteLine(Math.Round(sumAfterPay, 2));
        }
    }
}
