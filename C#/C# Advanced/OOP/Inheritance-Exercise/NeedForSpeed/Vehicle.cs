using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double defaultFuelConsumption = 1.25;
    
        public Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }

        public virtual double FuelConsumption => defaultFuelConsumption;
   
        public double Fuel { get; protected set; }

        public int HorsePower { get; protected set; }

        public virtual void Drive(double kilometers)
        {
            double fuelNeeded = this.FuelConsumption * kilometers;
            if (this.Fuel >= fuelNeeded)
            {
                this.Fuel -= fuelNeeded;
            }
        }
    }
}
