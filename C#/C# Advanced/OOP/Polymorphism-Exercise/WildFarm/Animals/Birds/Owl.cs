using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food)
        {
            Console.WriteLine("Hoot Hoot");
            if (food is Meat)
            {
                this.FoodEaten += food.Quantity;
                this.Weight += food.Quantity * 0.25;
            }
            else
            {
                string foodType = food.GetType().Name;
                Console.WriteLine($"Owl does not eat {foodType}!");
            }
        }

        public override string ToString()
        {
            return $"Owl [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
