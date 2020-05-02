using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int s = height * width;
            int allPieces = s;
            var input = Console.ReadLine();
            while (input != "STOP")
            {
                int pieces = int.Parse(input);
                allPieces = allPieces - pieces;
                if (allPieces < 0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(allPieces));
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine("{0} pieces are left.", allPieces);
            }
        }
    }
}
