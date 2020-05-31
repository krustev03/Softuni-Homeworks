﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStationRecruitment
{
    public class Astronaut
    {
        public Astronaut(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Country { get; private set; }

        public override string ToString()
        {
            string result = $"Astronaut: {this.Name}, {this.Age} ({this.Country})";
            result = result.TrimEnd();
            return result;
        }
    }
}
