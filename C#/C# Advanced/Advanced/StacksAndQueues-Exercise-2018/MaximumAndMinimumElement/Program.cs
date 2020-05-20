using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                List<int> command = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
                if (command[0] == 1)
                {
                    nums.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    if (nums.Any() == true)
                    {
                        nums.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    Stack<int> copycat = new Stack<int>(nums);
                    if (copycat.Any() == true)
                    {
                        var max = copycat.Pop();
                        while (copycat.Count > 0)
                        {
                            if (copycat.Peek() > max)
                            {
                                max = copycat.Pop();
                            }
                            else
                            {
                                copycat.Pop();
                            }
                        }
                        Console.WriteLine(max);
                    }
                }
                else if (command[0] == 4)
                {
                    Stack<int> copycat = new Stack<int>(nums);
                    if (copycat.Any() == true)
                    {
                        var min = copycat.Pop();
                        while (copycat.Count > 0)
                        {
                            if (copycat.Peek() < min)
                            {
                                min = copycat.Pop();
                            }
                            else
                            {
                                copycat.Pop();
                            }
                        }
                        Console.WriteLine(min);
                    }
                }
            }
            List<int> result = nums.ToList();
            for (int i = 0; i < result.Count; i++)
            {
                if (i == result.Count - 1)
                {
                    Console.WriteLine(result[i]);
                }
                else
                {
                    Console.Write(result[i] + ", ");
                }
            }
        }
    }
}
