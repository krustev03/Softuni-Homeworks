using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double sumEven = 0;
            double sumOdd = 0;
            int checkOdd = 0;
            int checkEven = 0;
            double previousNumEven = 0;
            double previousNumOdd = 0;
            double maxEven = double.MinValue;
            double maxOdd = double.MinValue;
            double minEven = double.MaxValue;
            double minOdd = double.MaxValue;

            for (int i = 1; i <= n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    sumOdd += num;
                    if (num > maxOdd) 
                    {
                        maxOdd = num;
                    }
                    if (num < minOdd)
                    {
                        minOdd = num;
                    }
                    checkOdd = 1;
                    previousNumOdd = num;
                }
                if (i % 2 == 0)
                {
                    sumEven += num;
                    if (num > maxEven)
                    {
                        maxEven = num;
                    }
                    if (num < minEven)
                    {
                        minEven = num;
                    }
                    checkEven = 1;
                    previousNumEven = num;
                }
            }

            Console.WriteLine("OddSum={0},", sumOdd);
            if (checkOdd == 1)
            {
                Console.WriteLine("OddMin={0},", minOdd);
                Console.WriteLine("OddMax={0},", maxOdd);
            }
            if (checkOdd == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            Console.WriteLine("EvenSum={0},", sumEven);
            if (checkEven == 1)
            {
                Console.WriteLine("EvenMin={0},", minEven);
                Console.WriteLine("EvenMax={0}", maxEven);
            }
            if (checkEven == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
