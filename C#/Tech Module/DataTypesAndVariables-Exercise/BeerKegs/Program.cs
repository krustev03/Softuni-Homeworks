using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = 0.0;
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float r = float.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                double volume = Math.PI * (r * r) * h;
                if (volume >= max)
                {
                    result = model;
                    max = volume;
                }
            }
            Console.WriteLine(result);
        }
    }
}
