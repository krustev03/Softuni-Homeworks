using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            int numsLength = nums.Count;
            for (int i = 0; i < numsLength / 2; i++)
            {
                nums[i] += nums[nums.Count - 1];
                nums.Remove(nums[nums.Count - 1]);
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
