using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class PalindromePermutation
    {
        public bool IsIt(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s.ToLower().ToCharArray())
            {
                if (c < 'a' || c > 'z')
                    continue;

                if (map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }

            bool middle = false;
            foreach (char key in map.Keys)
            {                
                if(map[key]%2 == 1)
                {
                    if (middle)
                        return false;

                    middle = true;
                }
            }

            return true;
        }
    }
}
