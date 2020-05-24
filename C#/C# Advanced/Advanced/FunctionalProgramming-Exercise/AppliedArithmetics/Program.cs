using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int[], int[]> operationAdd = Add;
            Func<int[], int[]> operationSubtract = Subtract;
            Func<int[], int[]> operationMultiply = Multiply;
            Action<int[]> operationPrint = Print;

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                switch(command)
                {
                    case "add":
                        nums = operationAdd(nums);
                        break;
                    case "subtract":
                        nums = operationSubtract(nums);
                        break;
                    case "multiply":
                        nums = operationMultiply(nums);
                        break;
                    case "print":
                        Print(nums);
                        break;
                }
            }
        }

        private static int[] Add(int[] oldArr)
        {
            int[] newArr = oldArr.Select(n => n + 1).ToArray();
            return newArr;
        }

        private static int[] Subtract(int[] oldArr)
        {
            int[] newArr = oldArr.Select(n => n - 1).ToArray();
            return newArr;
        }

        private static int[] Multiply(int[] oldArr)
        {
            int[] newArr = oldArr.Select(n => n * 2).ToArray();
            return newArr;
        }

        private static void Print(int[] oldArr)
        {
            string result = String.Join(" ", oldArr);
            Console.WriteLine(result);
        }
    }
}
