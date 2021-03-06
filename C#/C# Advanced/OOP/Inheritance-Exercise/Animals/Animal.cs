﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => this.name;

            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get => this.gender;

            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.gender = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2} {3} {4}{1}{5}",

                this.GetType().Name, // 0

                Environment.NewLine, // 1

                this.name, // 2

                this.age,  // 3

                this.gender, // 4

                this.ProduceSound()); // 5

        }

        public abstract string ProduceSound(); 
    }
}
