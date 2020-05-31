using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }

        public Stat Stat { get; set; }

        public Weapon Weapon { get; set; }

        public int GetTotalPower()
        {
            var sum = Weapon.Sharpness + Weapon.Size + Weapon.Solidity 
                + Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return sum;
        }

        public int GetWeaponPower()
        {
            var sum = Weapon.Sharpness + Weapon.Size + Weapon.Solidity;
            return sum;
        }

        public int GetStatPower()
        {
            var sum = Stat.Agility + Stat.Flexibility + Stat.Intelligence + Stat.Skills + Stat.Strength;
            return sum;
        }

        public override string ToString()
        {
            return $"{this.Name} - {GetTotalPower()}"
                + Environment.NewLine
                + $" Weapon Power: {GetWeaponPower()}"
                + Environment.NewLine 
                + $" Stat Power: {GetStatPower()}";
        }
    }
}
