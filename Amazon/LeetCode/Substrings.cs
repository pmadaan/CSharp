//https://leetcode.com/discuss/interview-question/370112

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Substrings
    {
        public List<string> getUniqueSubstrings(string s, int k)
        {
            HashSet<string> res = new HashSet<string>();
            for(int i=0; i<s.Length-k+1; i++)
            {
                List<char> str = new List<char>();
                for(int j=i; j<i+k; j++)
                {
                    if (str.Contains(s[j]))
                        break;

                    str.Add(s[j]);
                }
                if (str.Count == k)
                    res.Add(new string(str.ToArray()));
            }

            return res.ToList();
        }
    }
}
