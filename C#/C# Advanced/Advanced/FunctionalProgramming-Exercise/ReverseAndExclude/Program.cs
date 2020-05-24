using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var newNums = nums.Reverse().ToArray();
            int n = int.Parse(Console.ReadLine());
            Func<int[], int, string> remover = Remover;
            string result = Remover(newNums, n);
            Console.WriteLine(result);
        }

        private static string Remover(int[] arr, int n)
        {
            int[] newArr = arr.Select(x => x).Where(x => x % n != 0).ToArray();
            string result = String.Join(" ", newArr);
            return result;
        }
    }
}
