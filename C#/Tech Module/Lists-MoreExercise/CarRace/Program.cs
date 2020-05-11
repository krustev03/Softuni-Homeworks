using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> leftSide = new List<int>();
            List<int> rightSide = new List<int>();
            int middle = nums.Count / 2;
            for (int i = 0; i < nums.Count / 2; i++)
            {
                leftSide.Insert(i, nums[i]);
            }
            for (int i = 0; i < middle; i++)
            {
                rightSide.Insert(i, nums[nums.Count - 1 - i]);
            }
            double leftTime = 0;
            double rightTime = 0;
            for (int i = 0; i < leftSide.Count; i++)
            {
                if (leftSide[i] == 0)
                {
                    leftTime = leftTime * 0.8;
                }
                else
                {
                    leftTime += leftSide[i];
                }
            }
            for (int i = 0; i < middle; i++)
            {
                if (rightSide[i] == 0)
                {
                    rightTime = rightTime * 0.8;
                }
                else
                {
                    rightTime += rightSide[i];
                }
            }
            if (leftTime <= rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
        }
    }
}
