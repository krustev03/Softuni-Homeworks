using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                
                if (input == "END")
                {
                    break;
                }

                var all = input.Split(", ");

                string command = all[0];
                string car = all[1];

                switch(command)
                {
                    case "IN":
                        cars.Add(car);
                        break;
                    case "OUT":
                        cars.Remove(car);
                        break;
                }
            }

            if (cars.Count != 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
