using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> leftSocks = new Stack<int>(firstInput);
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> rightSocks = new Queue<int>(secondInput);
            List<int> pairs = new List<int>();

            while(leftSocks.Count != 0 && rightSocks.Count != 0)
            {
                if (leftSocks.Peek() > rightSocks.Peek())
                {
                    int pair = leftSocks.Pop() + rightSocks.Dequeue();
                    pairs.Add(pair);
                }
                else if (leftSocks.Peek() < rightSocks.Peek())
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    int numToAdd = leftSocks.Pop() + 1;
                    leftSocks.Push(numToAdd);
                }
            }

            var biggestSet = pairs.OrderByDescending(x => x).FirstOrDefault();
            Console.WriteLine(biggestSet);
            Console.WriteLine(String.Join(" ", pairs));
        }
    }
}
