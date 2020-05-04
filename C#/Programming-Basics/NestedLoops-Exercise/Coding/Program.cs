using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string num = Convert.ToString(n);
            for (int i = 0; i < num.Length; i++)
            { 
                if (n % 10 == 0)
                {
                    Console.Write("ZERO");
                }
                int lastNum = n % 10 + 33;
                char symbol = (char)lastNum;
                Console.WriteLine(new string(symbol, n % 10));
                n = (n - n % 10) / 10;
            }
        }
    }
}
