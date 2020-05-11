using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string ourString = Console.ReadLine();
            List<char> our = ourString.ToList();
            string result = string.Empty;
            while(nums.Count > 0)
            {
                int sumOfDigits = 0;
                while (nums[0] > 0)
                {
                    
                    sumOfDigits += nums[0] % 10;
                    nums[0] = nums[0] / 10;
                }
                nums.RemoveAt(0);
                while (true)
                {
                    if (sumOfDigits < our.Count)
                    {
                        result = result + our[sumOfDigits];
                        our.RemoveAt(sumOfDigits);
                        break;
                    }
                    else
                    {
                        sumOfDigits = sumOfDigits - (our.Count);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
