using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> NSX = Console.ReadLine().Split().Select(int.Parse).ToList();
            int toPush = NSX[0];
            int toPop = NSX[1];
            int numToFound = NSX[2];
            Stack<int> stack = new Stack<int>();
            List<int> numsToPush = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < toPush; i++)
            {
                stack.Push(numsToPush[i]);
            }
            
            for (int i = 0; i < toPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            if (stack.Contains(numToFound))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any() == false)
                {
                    Console.WriteLine(0);
                } 
                else
                {
                    int min = stack.Pop();
                    while (stack.Count > 1)
                    {
                        if (min >= stack.Peek())
                        {
                            min = stack.Pop();
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    Console.WriteLine(min);
                }
                
            }
        }
    }
}
