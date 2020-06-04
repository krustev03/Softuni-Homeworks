using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }



        string State { get; }



        void CompleteMission();
    }
}
