using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> nums2 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> result = new List<double>();
            int addMore = Math.Max(nums1.Count, nums2.Count);
            int length = Math.Min(nums1.Count, nums2.Count);
            int nums1Index = 0;
            int nums2Index = 0;
            for (int i = 0; i < length * 2; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(nums1[nums1Index]);
                    nums1Index++;
                }
                else
                {
                    result.Add(nums2[nums2Index]);
                    nums2Index++;
                }
                if (i == (length * 2) - 1)
                {
                    for (int m = length; m < addMore; m++)
                    {
                        if (nums1.Count >= nums2.Count)
                            result.Add(nums1[m]);
                        else
                            result.Add(nums2[m]);
                    }
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
