using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double SUM = double.Parse(Console.ReadLine());
            string IncomingCurrency = (Console.ReadLine());
            string SourceCurrency = (Console.ReadLine());


            if (IncomingCurrency == "BGN")
            {
                if (SourceCurrency == "USD")
                    Console.WriteLine("{0:f2} USD", SUM / 1.79549);

                else if (SourceCurrency == "EUR")
                    Console.WriteLine("{0:f2} EUR", SUM / 1.95583);

                else if (SourceCurrency == "GBP")
                    Console.WriteLine("{0:f2} GBP", SUM / 2.53405);
            }
            if (IncomingCurrency == "USD")
            {
                if (SourceCurrency == "BGN")
                    Console.WriteLine("{0:f2} BGN", SUM * 1.79549);

                else if (SourceCurrency == "EUR")
                    Console.WriteLine("{0:f2} EUR", SUM * 1.79549 / 1.95583);

                else if (SourceCurrency == "GBP")
                    Console.WriteLine("{0:f2} GBP", SUM * 1.79549 / 2.53405);
            }
            if (IncomingCurrency == "EUR")
            {
                if (SourceCurrency == "BGN")
                    Console.WriteLine("{0:f2} BGN", SUM * 1.95583);

                else if (SourceCurrency == "USD")
                    Console.WriteLine("{0:f2} USD", SUM * 1.95583 / 1.79549);

                else if (SourceCurrency == "GBP")
                    Console.WriteLine("{0:f2} GBP", SUM * 1.95583 / 2.53405);
            }
            if (IncomingCurrency == "GBP")
            {
                if (SourceCurrency == "BGN")
                    Console.WriteLine("{0:f2} BGN", SUM * 2.53405);

                else if (SourceCurrency == "USD")
                    Console.WriteLine("{0:f2} USD", SUM * 2.53405 / 1.79549);

                else if (SourceCurrency == "EUR")
                    Console.WriteLine("{0:f2} EUR", SUM * 2.53405 / 1.95583);
            }
        }
    }
}
        
    

