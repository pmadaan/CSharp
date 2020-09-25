using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourInteractive
{
    class MaxPoints
    {
        public int solution(string S, int[] X, int[] Y)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            double[] distances = new double[S.Length];
            double maxRadius = 0, prev = 0;
            bool reduced = false;
            List<char> tags = new List<char>();

            for (int i = 0; i < S.Length; i++)
            {
                distances[i] = Math.Sqrt(Math.Pow(X[i], 2) + Math.Pow(Y[i], 2));

                if (!tags.Contains(S[i]))
                {
                    if (!reduced)
                    {
                        if (distances[i] > maxRadius)
                        {
                            prev = maxRadius;
                            maxRadius = distances[i];
                        }
                        else if (distances[i] > prev) 
                            prev = distances[i];
                        tags.Add(S[i]);
                    }
                    else
                    {
                        if (distances[i] <= maxRadius)
                            tags.Add(S[i]);
                    }
                }

                else
                {
                    if (distances[i] <= maxRadius)
                    {
                        maxRadius = prev;
                        reduced = true;
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (distances[i] <= maxRadius)
                    count++;
            }

            return count;
        }
    }
}
