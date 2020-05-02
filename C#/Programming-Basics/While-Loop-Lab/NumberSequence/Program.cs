using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int maxnum = int.MinValue;
            int minnum = int.MaxValue;


            while (input != "END")
            {
                int digit = int.Parse(input);
                if (digit > maxnum)
                {
                    maxnum = digit;
                }
                if (digit < minnum)
                {
                    minnum = digit;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Max number: {0}", maxnum);
            Console.WriteLine("Min number: {0}", minnum);
        }
    }
}
