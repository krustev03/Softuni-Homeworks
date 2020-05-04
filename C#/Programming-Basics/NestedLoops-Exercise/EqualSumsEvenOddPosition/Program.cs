using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                string lengthFirst = Convert.ToString(i);
                int sumOdd = 0;
                int sumEven = 0;
                for (int r = 0; r < lengthFirst.Length; r++)
                {
                    if (r % 2 != 0)
                    {
                        sumOdd += lengthFirst[r];
                    }
                    if (r % 2 == 0)
                    {
                        sumEven += lengthFirst[r];
                    }
                }
                if (sumOdd == sumEven)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
