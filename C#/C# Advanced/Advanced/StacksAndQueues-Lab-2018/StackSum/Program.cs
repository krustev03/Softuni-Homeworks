using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> currNums = new Stack<int>(nums);
            while (true)
            {
                var command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    Console.WriteLine($"Sum: {currNums.Sum()}");
                    break;
                }
                var parts = command.Split();
                if (parts[0].ToLower() == "add")
                {
                    currNums.Push(int.Parse(parts[1]));
                    currNums.Push(int.Parse(parts[2]));
                }
                else if (parts[0].ToLower() == "remove")
                {
                    int times = int.Parse(parts[1]);
                    if (times > currNums.Count) { continue; }
                    for (int i = 0; i < times; i++)
                    {
                        currNums.Pop();
                    }
                }
            }
            
        }
    }
}
