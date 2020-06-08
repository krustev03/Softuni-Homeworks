using System;
using System.Collections.Generic;
using System.Text;

namespace Loggerr.LogFiles
{
    public interface ILogFile

    {

        int Size { get; }



        void Write(string content);

    }
}
