using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite
{
    public interface ISpecialisedSoldier : IPrivate
    {
        string Corps { get; } 
    }
}
