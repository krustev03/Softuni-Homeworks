using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }

        public string Name { get; set; }

        public int Count
        {
            get
            {
                return this.gladiators.Count;
            }
        }

        public void Add(Gladiator gladiator)
        {
            this.gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            var gladiator = this.gladiators.Where(x => x.Name == name).FirstOrDefault();

            this.gladiators.Remove(gladiator);
        }

        public Gladiator GetGladiatorWithHighestStatPower()
        {
            var highestStatPower = this.gladiators.OrderByDescending(x => x.GetStatPower()).FirstOrDefault();

            return highestStatPower;
        }

        public Gladiator GetGladiatorWithHighestWeaponPower()
        {
            var highestWeaponPower = this.gladiators.OrderByDescending(x => x.GetWeaponPower()).FirstOrDefault();

            return highestWeaponPower;
        }

        public Gladiator GetGladiatorWithHighestTotalPower()
        {
            var highestTotalPower = this.gladiators.OrderByDescending(x => x.GetTotalPower()).FirstOrDefault();

            return highestTotalPower;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Count} gladiators are participating.";
        }
    }
}
