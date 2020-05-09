using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] train = new int[n];
            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write(train[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
