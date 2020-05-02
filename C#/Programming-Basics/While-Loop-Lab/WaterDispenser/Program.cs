using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int easy = 50;
            int medium = 100;
            int hard = 200;
            int space = 0;
            int tap = 0;
            double volume = double.Parse(Console.ReadLine());
            while (space < volume)
            {
                string type = Console.ReadLine();
                if (type == "Easy")
                {
                    space += easy;
                    tap++;
                }
                if (type == "Medium")
                {
                    space += medium;
                    tap++;
                }
                if (type == "Hard")
                {
                    space += hard;
                    tap++;
                }
            }
            if (volume == space)
            {
                Console.WriteLine("The dispenser has been tapped {0} times.", tap);
            }
            else
            {
                Console.WriteLine("{0}ml has been spilled.", space - volume);
            }
        }
    }
}
