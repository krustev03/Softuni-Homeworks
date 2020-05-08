using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long num1 = 0;
            long num2 = 0;
            for (int i = 0; i < rows; i++)
            {
                long sum = 0;
                string a = Console.ReadLine();
                num1 = long.Parse(a.Substring(0 , a.IndexOf(" ")));
                num2 = long.Parse(a.Substring(a.IndexOf(" ") + 1, a.Length - a.IndexOf(" ") - 1));

                if (num1 > num2)
                {
                    while (num1 != 0)
                    {
                        sum += num1 % 10;
                        num1 /= 10;
                    }

                }
                else
                {
                    while (num2 != 0)
                    {
                        sum += num2 % 10;
                        num2 /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
        
    }
}
