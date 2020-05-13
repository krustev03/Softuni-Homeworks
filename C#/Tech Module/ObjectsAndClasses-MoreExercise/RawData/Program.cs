using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tyre> tyres;

        public Car(string model)
        {
            this.Model = model;
            this.tyres = new List<Tyre>();
        }

        internal string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        internal Engine Engine
        {
            get
            {
                return this.engine;
            }

            set
            {
                this.engine = value;
            }
        }

        internal Cargo Cargo
        {
            get
            {
                return this.cargo;
            }

            set
            {
                this.cargo = value;
            }
        }

        internal void AddTyre(Tyre tyre)
        {
            this.tyres.Add(tyre);
        }

        internal IReadOnlyList<Tyre> Tyres
        {
            get
            {
                return this.tyres.AsReadOnly();
            }
        }
    }
    class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }

        internal int Weight
        {
            get
            {
                return this.weight;
            }

            private set
            {
                this.weight = value;
            }
        }

        internal string Type
        {
            get
            {
                return this.type;
            }

            private set
            {
                this.type = value;
            }
        }
    }
    class Engine
    {
        private int speed;
        private int power;

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        internal int Speed
        {
            get
            {
                return this.speed;
            }

            private set
            {
                this.speed = value;
            }
        }

        internal int Power
        {
            get
            {
                return this.power;
            }

            private set
            {
                this.power = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                Car car = new Car(tokens[0]);
                car.Engine = new Engine(int.Parse(tokens[1]), int.Parse(tokens[2]));
                car.Cargo = new Cargo(int.Parse(tokens[3]), tokens[4]);

                for (int j = 0; j < 8; j += 2)
                {
                    car.AddTyre(new Tyre(double.Parse(tokens[j + 5]), int.Parse(tokens[j + 6])));
                }

                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == command && c.Tyres.Any(t => t.Pressure < 1)).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            else if (command == "flammable")
            {
                cars.Where(c => c.Cargo.Type == command && c.Engine.Power > 250).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
    class Tyre
    {
        private double pressure;
        private int age;

        public Tyre(double pressure, int age)
        {
            this.Pressure = pressure;
            this.Age = age;
        }

        internal double Pressure
        {
            get
            {
                return this.pressure;
            }

            private set
            {
                this.pressure = value;
            }
        }

        internal int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }
    }
}
