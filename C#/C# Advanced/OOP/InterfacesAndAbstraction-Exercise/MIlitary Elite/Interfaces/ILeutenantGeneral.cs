using System;
using System.Collections.Generic;
using System.Text;

namespace MIlitary_Elite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
    }
}
