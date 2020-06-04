using System;
using System.Collections.Generic;
using System.Text;

namespace FerrariProblem
{
    public interface IFerrarable
    {
        string Model { get; }

        string Driver { get; }

        string UseBrakes();

        string PushGas();
    }
}
