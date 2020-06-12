using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    public class InvalidPersonNameException : Exception
    {
        public InvalidPersonNameException(string msg)
            : base(msg)
        {

        }
    }
}
