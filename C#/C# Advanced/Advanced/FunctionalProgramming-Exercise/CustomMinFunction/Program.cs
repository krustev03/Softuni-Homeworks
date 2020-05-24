using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minNum = GetMin;
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var minNumber = minNum(input);
            Console.WriteLine(minNumber);
        }

        private static int GetMin (int[] nums)
        {
            var min = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
