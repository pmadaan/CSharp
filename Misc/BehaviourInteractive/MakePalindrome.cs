using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourInteractive
{
    class MakePalindrome
    {
        public string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            char[] t = new char[S.Length];

            for (int i = 0; i < S.Length / 2; i++)
            {
                int j = S.Length - i - 1;
                
                if (S[i] == '?')
                {
                    if (S[j] == '?')
                        t[j] = 'a';
                    else t[j] = S[j];

                    t[i] = t[j];
                }
                else if (S[j] == '?')
                {
                    t[i] = t[j] = S[i];
                }
                else if (!S[i].Equals(S[j]))
                    return "NO";
                else
                    t[i] = t[j] = S[i];

            }
            if (S.Length % 2 == 1)
            {
                if (S[S.Length / 2] != '?')
                    t[S.Length / 2] = S[S.Length / 2];
                else
                    t[S.Length / 2] = 'a';
            }

            return new string(t);


        }
    }
}
