using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var element = arr[0];
                for (int k = 1; k < arr.Length; k++)
                {
                    arr[k - 1] = arr[k];
                }
                arr[arr.Length - 1] = element;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
