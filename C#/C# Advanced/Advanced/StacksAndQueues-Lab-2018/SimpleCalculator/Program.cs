using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(text.Reverse());
            int result = int.Parse(stack.Pop());
            foreach (var symbol in text)
            {
                if (symbol == "+")
                {
                    stack.Pop();
                    result += int.Parse(stack.Pop());
                }
                else if (symbol == "-")
                {
                    stack.Pop();
                    result -= int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
