using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public Item(int strength, int ability, int intelligence)
        {
            Strength = strength;
            Ability = ability;
            Intelligence = intelligence;
        }

        public int Strength { get; private set; }

        public int Ability { get; private set; }

        public int Intelligence { get; private set; }

        public override string ToString()
        {
            string result = "Item:"
                + Environment.NewLine
                + $"  * Strength: {this.Strength}"
                + Environment.NewLine
                + $"  * Ability: {this.Ability}"
                + Environment.NewLine
                + $"  * Intelligence: {this.Intelligence}";

            return result;
        }
    }
}
