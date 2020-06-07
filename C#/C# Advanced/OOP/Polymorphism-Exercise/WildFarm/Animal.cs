using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm
{
    public abstract class Animal
    {
        private string name;
        private double weight;
        private int foodEaten = 0;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public string Name { get; private set; }

        public double Weight { get; set; }

        public int FoodEaten { get; set; }

        public abstract void Eat(Food food); 
    }
}
