using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int k = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                switch (tokens[0])
                {
                    case "Contains":
                        if (nums.Contains(Convert.ToInt32(tokens[1])) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":

                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 == 0)
                            {
                                Console.Write(nums[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":

                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] % 2 != 0)
                            {
                                Console.Write(nums[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < nums.Count; i++)
                        {
                            sum += nums[i];
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        Filter(nums, tokens);
                        Console.WriteLine();
                        break;
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        nums.Add(numberToAdd);
                        k = 1;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        nums.Remove(numberToRemove);
                        k = 1;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        nums.RemoveAt(indexToRemove);
                        k = 1;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        nums.Insert(indexToInsert, numberToInsert);
                        k = 1;
                        break;
                }
            }
            if (k != 0)
            {
                Console.WriteLine(string.Join(" ", nums));
            }
        }
        static void Filter(List<int> nums, string[] tokens)
        {
            switch (tokens[1])
            {
                case "<":
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] < Convert.ToInt32(tokens[2]))
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] <= Convert.ToInt32(tokens[2]))
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    break;
                case ">":
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] > Convert.ToInt32(tokens[2]))
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] >= Convert.ToInt32(tokens[2]))
                        {
                            Console.Write(nums[i] + " ");
                        }
                    }
                    break;
            }
        }
    }
}
