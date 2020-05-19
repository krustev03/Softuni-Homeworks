using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int singleCookieGram = 25;
            int cup = 140;
            int smallSpoon = 10;
            int bigSpoon = 20;
            int cookiesPerBox = 5;
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());
                int flourCups = flour / cup;
                int sugarSpoons = sugar / bigSpoon;
                int cocoaSpoons = cocoa / smallSpoon;
                if (flourCups <= 0 || sugarSpoons <= 0 || cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    int totalCookiesPerBake = (cup + smallSpoon + bigSpoon) *
                        Math.Min(Math.Min(flourCups, sugarSpoons), Math.Min(sugarSpoons, cocoaSpoons)) / singleCookieGram;
                   
                    int boxesPerBatch = totalCookiesPerBake / cookiesPerBox;
                    total += boxesPerBatch;
                    Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
                }
            }
            Console.WriteLine($"Total boxes: {total}");
        }
    }
}
