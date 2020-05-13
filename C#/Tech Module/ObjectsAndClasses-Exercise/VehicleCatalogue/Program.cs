using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            double averageCarHP = 0;
            double averageTruckHP = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] parts = command.Split();
                if (parts[0] == "car")
                {
                    var car = new Car(parts[1], parts[2], Convert.ToInt32(parts[3]));
                    cars.Add(car);
                    averageCarHP += Convert.ToInt32(parts[3]);
                }
                if (parts[0] == "truck")
                {
                    var truck = new Truck(parts[1], parts[2], Convert.ToInt32(parts[3]));
                    averageTruckHP += Convert.ToInt32(parts[3]);
                    trucks.Add(truck);
                }
            }
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }
                foreach (Car car in cars)
                {
                    if (model == car.Model)
                    {
                        car.PrintCar(car);
                    }
                }
                foreach (Truck truck in trucks)
                {
                    if (model == truck.Model)
                    {
                        truck.PrintTruck(truck);
                    }
                }
            }
            averageCarHP = averageCarHP / cars.Count;
            averageTruckHP = averageTruckHP / trucks.Count;
            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
            
        }
    }
    class Car
    {
        public Car(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public void PrintCar(Car car)
        {
            Console.WriteLine($"Type: Car"); 
            Console.WriteLine($"Model: {car.Model}"); 
            Console.WriteLine($"Color: {car.Color}"); 
            Console.WriteLine($"Horsepower: {car.HorsePower}"); 

        }
    }
    class Truck
    {
        public Truck(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
        public void PrintTruck(Truck truck)
        {
            Console.WriteLine($"Type: Truck");
            Console.WriteLine($"Model: {truck.Model}");
            Console.WriteLine($"Color: {truck.Color}");
            Console.WriteLine($"Horsepower: {truck.HorsePower}");

        }
    }
}
