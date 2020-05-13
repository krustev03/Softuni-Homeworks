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
            while (true)
            {

                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] parts = command.Split('/').ToArray();
                string type = parts[0];
                if (type == "Car")
                {
                    var car = new Car(parts[1], parts[2], Convert.ToInt32(parts[3]));
                    cars.Add(car);
                }
                if (type == "Truck")
                {
                    var truck = new Truck(parts[1], parts[2], Convert.ToInt32(parts[3]));
                    trucks.Add(truck);
                }
            }
            cars = cars.OrderBy(x => x.Brand).ToList();
            trucks = trucks.OrderBy(x => x.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
}
