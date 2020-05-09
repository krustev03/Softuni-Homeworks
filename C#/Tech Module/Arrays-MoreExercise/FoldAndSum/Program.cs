using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] firstRow = new int[k * 2];
            int incr = 0;
            for (int i = k - 1; i >= 0; i--)
            {
                
                firstRow[i] = arr[incr];
                incr++;
            }
            int[] secondRow = new int[k * 2];
            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = arr[k + i];
            }
            int incr2 = 1;
            for (int i = k; i < k * 2; i++)
            {
                firstRow[i] = arr[4 * k - incr2];
                incr2++;
            }
            for (int i = 0; i < firstRow.Length; i++)
            {
                Console.Write(firstRow[i] + secondRow[i] + " ");
            }
            
        }
    }
}
