// https://leetcode.com/discuss/interview-question/542597/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Keywords
    {
        public static List<string> TopKFrequent(string[] keywords, string[] reviews, int k)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();
            foreach(string review in reviews)
            {
                string[] words = review.ToLower().Split(" ");
                HashSet<string> added = new HashSet<string>();
                foreach(string word in words)
                {
                    if (keywords.Contains(word) && !added.Contains(word))
                    {
                        if (freq.ContainsKey(word))
                            freq[word]++;
                        else
                            freq[word] = 1;
                        added.Add(word);
                    }
                }
            }

           return freq.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).Take(k).ToList();

        }
    }
}
