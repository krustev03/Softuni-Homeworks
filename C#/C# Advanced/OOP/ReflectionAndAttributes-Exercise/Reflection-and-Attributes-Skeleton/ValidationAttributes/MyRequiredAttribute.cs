using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            return true;
        }
    }
}
