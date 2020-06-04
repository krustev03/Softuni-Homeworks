using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }
    }
}
