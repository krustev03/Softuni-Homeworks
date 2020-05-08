using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double h = double.Parse(Console.ReadLine());
            double V = ((length * width) * h) / 3.0;
            Console.WriteLine($"Pyramid Volume: {V:f2}");
        }
    }
}
