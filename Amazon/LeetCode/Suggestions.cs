//https://leetcode.com/problems/search-suggestions-system/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class Suggestions
    {
        public List<List<string>> SuggestedProducts(string[] products, string searchWord)
        {
            List<List<string>> res = new List<List<string>>();

            List<string> temp;
            string sub = "";
            foreach(char ch in searchWord)
            {
                sub += ch;
                temp = new List<string>();

                foreach(string product in products)
                {
                    if (product.StartsWith(sub))
                        temp.Add(product);
                }

                res.Add(temp.OrderBy(x => x).Take(3).ToList());
            }

            return res;
        }
    }
}