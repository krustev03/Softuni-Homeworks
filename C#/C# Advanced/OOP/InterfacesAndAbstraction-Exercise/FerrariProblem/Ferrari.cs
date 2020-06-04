using System;
using System.Collections.Generic;
using System.Text;

namespace FerrariProblem
{
    public class Ferrari : IFerrarable
    {
        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public string PushGas()
        {
            return "Gas!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }
    }
}
