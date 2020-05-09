using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noSums = true;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (i == arr.Length - 1)
                    {
                        k = i;
                    }
                    sumRight += arr[k];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    if (i == 0)
                    {
                        k = i;
                    }
                    sumLeft += arr[k];
                }
                if (sumLeft == sumRight)
                {
                    index = i;
                    noSums = false;
                }
            }
            if (noSums)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
