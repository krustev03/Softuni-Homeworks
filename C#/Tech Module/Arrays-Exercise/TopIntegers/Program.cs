using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;
                for (int k = i; k < arr.Length; k++)
                {
                    if (arr[i] <= arr[k] && i != k)
                    {
                        isTopInteger = false;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
