using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double commision = -1;
            
            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500) { commision = 0.05; }
                else if (sales > 500 && sales <= 1000) { commision = 0.07; }
                else if (sales > 1000 && sales <= 10000) { commision = 0.08; }
                else if (sales > 10000) { commision = 0.12; }
                if (commision >= 0)
                {
                    Console.WriteLine("{0:f2}", commision * sales);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            if (city == "varna")
            {
                if (sales >= 0 && sales <= 500) { commision = 0.045; }
                if (sales > 500 && sales <= 1000) { commision = 0.075; }
                if (sales > 1000 && sales <= 10000) { commision = 0.10; }
                if (sales > 10000) { commision = 0.13; }
                if (commision >= 0)
                {
                    Console.WriteLine("{0:f2}", commision * sales);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) { commision = 0.055; }
                if (sales > 500 && sales <= 1000) { commision = 0.08; }
                if (sales > 1000 && sales <= 10000) { commision = 0.12; }
                if (sales > 10000) { commision = 0.145; }
                if (commision >= 0)
                {
                    Console.WriteLine("{0:f2}", commision * sales);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
