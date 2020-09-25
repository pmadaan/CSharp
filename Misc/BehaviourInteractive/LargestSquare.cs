using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourInteractive
{
    class LargestSquare
    {
        public int solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A + B < 4)
                return 0;

            int maxSum = (A + B) - ((A + B) % 4);
            int sides = 0;
            int larger = (A > B) ? A : B;
            int smaller = A + B - larger;

            while (maxSum >= 4)
            {
                sides = getSides(larger, smaller, maxSum);

                if (sides < 4)
                    maxSum -= 4;
                else
                    break;
            }

            return maxSum / 4;
        }

        private int getSides(int a, int b, int sum)
        {
            int sides = 0;
            int len = sum / 4;
            while (a >= len)
            {
                a -= len;
                sides++;
            }
            while (b >= len)
            {
                b -= len;
                sides++;
            }

            return sides;
        }
    }
}
