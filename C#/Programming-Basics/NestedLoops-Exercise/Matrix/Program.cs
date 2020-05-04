using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());

            for (int firstRowFirstNum = a; firstRowFirstNum <= b; firstRowFirstNum++)
            {
                for (int firstRowSecondNum = a; firstRowSecondNum <= b; firstRowSecondNum++)
                {
                    for (int secondRowFirstNum = c; secondRowFirstNum <= d; secondRowFirstNum++)
                    {
                        for (int secondRowSecondNum = c; secondRowSecondNum <= d; secondRowSecondNum++)
                        {
                            if ((firstRowFirstNum + secondRowSecondNum) == (firstRowSecondNum + secondRowFirstNum)
                                && (firstRowFirstNum != firstRowSecondNum) && (secondRowFirstNum != secondRowSecondNum))
                            {
                                Console.WriteLine();
                                Console.WriteLine("{0}{1}", firstRowFirstNum, firstRowSecondNum);
                                Console.WriteLine("{0}{1}", secondRowFirstNum, secondRowSecondNum);
                            }
                        }
                    }
                }
            }
        }
    }
}
