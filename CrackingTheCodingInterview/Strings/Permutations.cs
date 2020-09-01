using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Strings
{
    class Permutations
    {
        public bool isPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            Dictionary<char, int> s1Map = new Dictionary<char, int>();
            foreach(char c in s1.ToCharArray())
            {
                if (s1Map.ContainsKey(c))
                    s1Map[c]++;
                else
                    s1Map[c] = 1;
            }

            foreach(char c in s2.ToCharArray())
            {
                if (s1Map.ContainsKey(c) && s1Map[c] > 0)
                    s1Map[c]--;
                else
                    return false;

                if (s1Map[c] == 0)
                    s1Map.Remove(c);
            }

            if (s1Map.Count > 0)
                return false;


            return true;
        }
    }
}
