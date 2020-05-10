using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            int evenIndex = 0;
            int oddIndex = 0;
            int[] evens = new int[evenIndex];
            int[] odds = new int[oddIndex];
            while (num > 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    Array.Resize(ref evens, evenIndex + 1);
                    evenIndex++;
                    evens[evenIndex - 1] = num % 10;
                    num = num / 10;
                }
                if ((num % 10) % 2 != 0)
                {
                    Array.Resize(ref odds, oddIndex + 1);
                    oddIndex++;
                    odds[oddIndex - 1] = num % 10;
                    num = num / 10;
                }
            }
            int evenSum = GetSumOfDigits(evens);
            int oddSum = GetSumOfDigits(odds);
            int multiple = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(multiple);
        }
        static int GetSumOfDigits (int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdds(int sum1, int sum2)
        {
            int multiple = sum1 * sum2;
            return multiple;
        }
    }
}
