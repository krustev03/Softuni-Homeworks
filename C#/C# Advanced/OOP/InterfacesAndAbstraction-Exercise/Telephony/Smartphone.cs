using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string site)
        {
            var chars = site.ToCharArray();

            bool hasDigit = false;

            foreach (char character in chars)
            {
                if (Char.IsDigit(character))
                {
                    hasDigit = true;
                }
            }

            if (hasDigit)
            {
                return "Invalid URL!";
            }
            else
            {
                return $"Browsing: {site}!";
            }
        }

        public string Call(string number)
        {
            var chars = number.ToCharArray();

            bool hasDiffFromDigit = false;

            foreach (char character in chars)
            {
                if (!Char.IsDigit(character))
                {
                    hasDiffFromDigit = true;
                }
            }

            if (hasDiffFromDigit)
            {
                return "Invalid number!";
            }
            else
            {
                return $"Calling... {number}";
            }
        }
    }
}
