using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourInteractive
{
    class MissingInteger
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int max = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0) continue;
                if (A[i] > max) max = A[i];
            }

            if (max == 0 || max == 1) return max + 1;

            int[] temp = new int[max];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] <= 0) continue;
                temp[A[i] - 1] = 1;
            }

            for (int j = 0; j < max; j++)
                if (temp[j] != 1) return j + 1;

            return max + 1;
        }
    }
}
