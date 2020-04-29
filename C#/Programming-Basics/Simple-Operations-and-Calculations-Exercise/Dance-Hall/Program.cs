using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());
            double room = (L * 100) * (W * 100);
            double wardrobe = (A * 100) * (A * 100);
            double bench = room / 10;
            double freeSpace = room - (wardrobe + bench);
            double dancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
