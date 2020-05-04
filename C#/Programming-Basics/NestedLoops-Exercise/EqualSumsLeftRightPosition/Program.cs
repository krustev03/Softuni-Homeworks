using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsLeftRightPosition
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
                int sumLeft = 0;
                int sumRight = 0;
                sumLeft = lengthFirst[0] + lengthFirst[1];
                sumRight = lengthFirst[3] + lengthFirst[4];
                if (sumLeft > sumRight)
                {
                    sumRight += int.Parse(lengthFirst[2].ToString());
                }
                if (sumLeft < sumRight)
                {
                    sumLeft += int.Parse(lengthFirst[2].ToString());
                }
                if (sumLeft == sumRight)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
