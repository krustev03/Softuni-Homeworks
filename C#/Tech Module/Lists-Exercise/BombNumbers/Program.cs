using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb[0])
                {
                    for (int k = 1; k <= bomb[1]; k++)
                    {
                        if (i + 1 < nums.Count)
                        {
                            nums[i + k] = 0;
                        }
                    }
                    for (int k = 1; k <= bomb[1]; k++)
                    {
                        if (i - k >= 0)
                        {
                            nums[i - k] = 0;
                        }    
                    }
                    nums[i] = 0;
                }
            }
            int sum = 0;
            foreach (int element in nums)
            {
                sum += element;
            }
            Console.WriteLine(sum);
        }
    }
}
