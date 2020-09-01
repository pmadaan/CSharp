using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class Compression
    {
        public string compress(string s)
        {
            //string t = "";
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<s.Length;)
            {
                //t += s[i];
                sb.Append(s[i]);
                int j = i + 1;
                while (j < s.Length && s[j].Equals(s[i])) j++;
                //t += (j - i).ToString();
                sb.Append((j-i).ToString());
                i = j;
            }

            //if (t.Length < s.Length)
            //    return t;

            if (sb.Length < s.Length)
                return sb.ToString();

            return s;
        }
    }
}
