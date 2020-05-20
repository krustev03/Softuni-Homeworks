using System;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> nums = new Dictionary<double, int>();

            var input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                double num = double.Parse(input[i]);
                if (!nums.ContainsKey(num))
                {
                    nums[num] = 0;
                }
                nums[num]++;
            }

            foreach (var item in nums)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
