using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthdate = birthday;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }
    }
}
