using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                PositiveOrNegative(num1, num2, num3);
            }
        }
        static void PositiveOrNegative(int num1, int num2, int num3)
        {
            int countNegative = 0;
            int[] nums = new int [3]{ num1, num2, num3 };
            for (int i = 0; i < 3; i++)
            {
                if (nums[i] < 0)
                {
                    countNegative++;
                }
            }
            if (countNegative % 2 == 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
