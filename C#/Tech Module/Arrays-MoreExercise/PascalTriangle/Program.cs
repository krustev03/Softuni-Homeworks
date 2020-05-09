using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[2];
            arr[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    Console.Write(arr[k] + " ");
                }
                Console.WriteLine();
                int[] newArr = new int[arr.Length + 1];
                for (int k = 0; k < arr.Length; k++)
                {
                    if (k == 0)
                    {
                        newArr[0] = 1;
                    }
                    else
                    {
                        newArr[k] = arr[k] + arr[k - 1];
                    }
                }
                arr = newArr;
            }
        }
    }
}
