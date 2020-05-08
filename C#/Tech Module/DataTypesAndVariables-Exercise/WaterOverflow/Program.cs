using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (capacity - liters < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum += liters;
                    capacity = capacity - liters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
