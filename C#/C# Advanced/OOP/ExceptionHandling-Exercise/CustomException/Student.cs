using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    public class Student
    {
        private string name;
        private string email;

        public Student(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name
        {
            get => this.name;

            private set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        throw new InvalidPersonNameException("The name must contain only letters.");
                    }
                }

                this.name = value;
            }
        }

        public string Email { get; private set; }
    }
}
