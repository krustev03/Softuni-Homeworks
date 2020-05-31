using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Astronaut>();
        }

        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            bool have = false;

            foreach (var item in this.data)
            {
                if (item.Name == name)
                {
                    have = true;
                }
            }

            if (have)
            {
                var astronaut = this.data.Where(x => x.Name == name).FirstOrDefault();
                this.data.Remove(astronaut);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Astronaut GetOldestAstronaut()
        {
            var oldestAstronaut = this.data.OrderByDescending(x => x.Age).FirstOrDefault();

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            var astronaut = this.data.Where(x => x.Name == name).FirstOrDefault();
         
            return astronaut;
        }

        public string Report()
        {
            StringBuilder allAstronauts = new StringBuilder($"Astronauts working at Space Station {this.Name}:");
            
            if (this.data.Any())
            {
                allAstronauts.Append($"{Environment.NewLine}" + String.Join(Environment.NewLine, this.data));
            }

            string result = allAstronauts.ToString();

            result = result.TrimEnd();

            return result;
        }
    }
}
