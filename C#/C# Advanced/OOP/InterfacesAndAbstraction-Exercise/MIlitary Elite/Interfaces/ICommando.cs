using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
