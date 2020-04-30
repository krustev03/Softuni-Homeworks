using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secPerM = double.Parse(Console.ReadLine());

            double speed = meters * secPerM;
            double waterR = Math.Floor((meters / 15)) * 12.5;
            double time = speed + waterR;
            if (time < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", time);
            }
            else if (time >= record) 
            {
                double difference = Math.Abs(record - time);
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", difference);
            }
                 
        }
    }
}
