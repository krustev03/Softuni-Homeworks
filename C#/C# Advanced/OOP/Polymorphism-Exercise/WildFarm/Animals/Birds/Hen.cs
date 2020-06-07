using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            Console.WriteLine("Cluck");
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.35;
        }

        public override string ToString()
        {
            return $"Hen [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
