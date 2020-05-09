using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i; k < arr.Length; k++)
                {
                    if (arr[i] + arr[k] == num && i != k)
                    {
                        Console.WriteLine(arr[i] + " " + arr[k]);
                    }
                }
            }
        }
    }
}
