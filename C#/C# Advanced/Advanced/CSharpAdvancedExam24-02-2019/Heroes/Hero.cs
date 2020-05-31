using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            Name = name;
            Level = level;
            Item = item;
        }

        public string Name { get; private set; }

        public int Level { get; private set; }

        public Item Item { get; private set; }

        public override string ToString()
        {
            string result = 
                Environment.NewLine
                + $"Hero: {this.Name} - {this.Level}lvl" 
                + Environment.NewLine
                + "Item:"
                + Environment.NewLine
                + $"  * Strength: {this.Item.Strength}"
                + Environment.NewLine
                + $"  * Ability: {this.Item.Ability}"
                + Environment.NewLine
                + $"  * Intelligence: {this.Item.Intelligence}";

            return result;
        }
    }
}
