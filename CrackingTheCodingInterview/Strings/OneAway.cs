using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class OneAway
    {
        public bool IsIt(string s1, string s2)
        {
            if (s1.Length == s2.Length)
                return checkReplacement(s1, s2);

            if (s1.Length == s2.Length - 1)
                return checkInsertion(s1, s2);

            if (s1.Length == s2.Length + 1)
                return checkInsertion(s2, s1);

            return false;
        }

        private bool checkReplacement(string s1, string s2)
        {
            bool found = false;
            for(int i=0; i<s1.Length; i++)
            {
                if(!s1[i].Equals(s2[i]))
                {
                    if (found)
                        return false;
                    found = true;
                }
            }
            return true;
        }

        private bool checkInsertion(string s1, string s2)
        {
            bool found = false;

            for(int i=0, j=0; i<s1.Length; i++, j++)
            {
                if(!s1[i].Equals(s2[j]))
                {
                    if (found)
                        return false;
                                        
                    j++;
                    if (s1[i].Equals(s2[j]))
                        found = true;
                    else
                        return false;
                }
            }

            return true;
        }
    }
}
