using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = 1;
            int max = 1;
            int element = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int oldElement = arr[i - 1];
                if (arr[i] == oldElement)
                {
                    k++;
                    if (k > max)
                    {
                        max = k;
                        element = arr[i];
                    }
                }
                else
                {
                    k = 1;
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
