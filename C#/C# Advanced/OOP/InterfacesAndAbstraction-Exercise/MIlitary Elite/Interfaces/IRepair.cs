using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Interfaces
{
    public interface IRepair
    {
        string Part { get; }

        int Hours { get; }
    }
}
