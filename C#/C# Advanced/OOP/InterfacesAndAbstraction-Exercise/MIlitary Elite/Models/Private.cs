using MIlitary_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, double salary)

        : base(id, firstName, lastName)

        {

            this.Salary = salary;

        }



        public double Salary { get; private set; }



        public override string ToString()

        {

            return $"{base.ToString()} Salary: {Salary:F2}";

        }
    }
}
