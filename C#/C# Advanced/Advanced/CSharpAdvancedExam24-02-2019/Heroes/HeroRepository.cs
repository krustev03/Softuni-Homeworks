using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public List<Hero> Data { get; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {
            var hero = this.data.Where(x => x.Name == name).FirstOrDefault();

            this.data.Remove(hero);
        }

        public Hero GetHeroWithHighestStrength()
        {
            var hero = this.data.OrderByDescending(x => x.Item.Strength).Take(1).First();
            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            var hero = this.data.OrderByDescending(x => x.Item.Ability).Take(1).First();
            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            var hero = this.data.OrderByDescending(x => x.Item.Intelligence).Take(1).First();
            return hero;
        }

        public override string ToString()
        {
            string result = String.Empty;
            foreach (var hero in this.data)
            {
                result += hero.ToString();
            }
            return result;
        }
    }
}
