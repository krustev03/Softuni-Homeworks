using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Interfaces
{
    public interface ISoldier
    {
        string Id { get; }

        string FirstName { get; }

        string LastName { get; }
    }
}
