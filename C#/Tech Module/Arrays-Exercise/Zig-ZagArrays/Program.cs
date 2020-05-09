using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            string[] consume;
            string arr1Nums = string.Empty;
            string arr2Nums = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string takeNum = Console.ReadLine();
                int takeNumOne = Convert.ToInt16(takeNum.Substring(0, takeNum.IndexOf(" ")));
                int takeNumTwo = Convert.ToInt16(takeNum.Substring(takeNum.IndexOf(" ") + 1, takeNum.Length - takeNum.IndexOf(" ") - 1));

                if (i % 2 == 0)
                {
                    arr2Nums += takeNumOne + " ";
                    arr1Nums += takeNumTwo + " ";
                }
                else
                {
                    arr2Nums += takeNumTwo + " ";
                    arr1Nums += takeNumOne + " ";
                }
            }
            Console.WriteLine(arr2Nums);
            Console.WriteLine(arr1Nums);
        }
    }
}
