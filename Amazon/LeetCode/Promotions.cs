//https://leetcode.com/discuss/interview-question/762546/

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Promotions
    {
        public int IsWinner(List<List<string>> codeList, List<string> shoppingCart)
        {
            if (codeList == null || codeList.Count == 0)
                return 1;

            int j = 0;
            for(int i=0; i<shoppingCart.Count; i++)
            {
                if (!shoppingCart[i].Equals(codeList[j][0]) && codeList[j][0] != "anything")
                    continue;

                int n = i+1;
                int k = 1;
                for(;k<codeList[j].Count && n<shoppingCart.Count; k++, n++)
                {
                    if (!shoppingCart[n].Equals(codeList[j][k]) && !codeList[j][k].Equals("anything"))
                        break;
                }

                if (k == codeList[j].Count)
                {
                    j++;
                    i = n - 1;
                }
                
            }

            if (j == codeList.Count)
                return 1;
            else
                return 0;
        }
    }
}
