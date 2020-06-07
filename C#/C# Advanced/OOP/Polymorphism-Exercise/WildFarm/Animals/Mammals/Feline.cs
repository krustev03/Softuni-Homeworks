﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammals
{
    public abstract class Feline : Mammal
    {
        private string breed;

        public Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; private set; }

    }
}
