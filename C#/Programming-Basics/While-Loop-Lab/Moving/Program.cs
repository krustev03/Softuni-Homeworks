using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volumeOfRoom = width * length * height;
            int allBoxes = 0;
            var input = Console.ReadLine();
            while (input != "Done")
            {
                int box = int.Parse(input);
                allBoxes = allBoxes + box;
                if (allBoxes >= volumeOfRoom)
                {
                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", allBoxes - volumeOfRoom);
                    break;
                }
                input = Console.ReadLine();
            }
            if (allBoxes < volumeOfRoom)
            {
                Console.WriteLine("{0} Cubic meters left.", volumeOfRoom - allBoxes);
            }
        }
    }
}
