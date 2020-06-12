using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ValidPersonProblem
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get => this.firstName;

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The First Name is invalid.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;

            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The Last Name is invalid.");
                }
                this.lastName = value;
            }
        } 

        public int Age
        {
            get => this.age;

            private set
            {
                if (value > 120 || value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The age must be between 0 and 120.");
                }
                this.age = value;
            }
        }
    }
}
