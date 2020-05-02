using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int enters = int.Parse(Console.ReadLine());
            double allSum = 0.0;
            int counter = 1;
            while (counter <= enters)
            {
                double sum = double.Parse(Console.ReadLine());
                if (sum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine("Increase: {0:f2}", sum);
                allSum += sum;
                counter++;
            }
            Console.WriteLine("Total: {0:f2}", allSum);
        }
    }
}
