using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class StringRotation
    {
        public bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            string t = s1 + s1;
            if (t.Contains(s2))
                return true;

            return false;
        }
    }
}
