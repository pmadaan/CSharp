//https://leetcode.com/discuss/interview-question/782606/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LeetCode
{
    class Association
    {
        public List<String> largestItemAssociation(List<PairString> itemAssociation)
        {
            List<HashSet<string>> associations = new List<HashSet<string>>();
            HashSet<string> added = new HashSet<string>();
            Dictionary<string, HashSet<string>> map = new Dictionary<string, HashSet<string>>();

            foreach (PairString pair in itemAssociation)
            {
                HashSet<string> temp;
                if(!map.TryGetValue(pair.first, out temp))
                    temp = new HashSet<string>();

                temp.Add(pair.first);
                temp.Add(pair.second);
                map[pair.first] = temp;

                if (!map.TryGetValue(pair.second, out temp))
                    temp = new HashSet<string>();

                temp.Add(pair.first);
                temp.Add(pair.second);
                map[pair.second] = temp;
            }

            HashSet<string> ass;
            foreach(string key in map.Keys)
            {
                if (added.Contains(key))
                    continue;

                added.Add(key);
                ass = map[key];

                while (true)
                {
                    HashSet<string> temp = new HashSet<string>(ass);
                    foreach (string val in temp)
                    {
                        if (added.Contains(val))
                            continue;

                        ass.UnionWith(map[val]);
                        added.Add(val);
                    }

                    if (temp.Count == ass.Count)
                        break;
                }

                associations.Add(ass);
            }

            return associations.OrderByDescending(x => x.Count).Select(x => x).First().ToList();
        }
    }

    public class PairString
    {
        public String first;
        public String second;

        public PairString(String first, String second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
