using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Interfaces
{
    public interface IPrivate : ISoldier
    {
        double Salary { get; }
    }
}
