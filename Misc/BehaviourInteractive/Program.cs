using System;

namespace BehaviourInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "ABDCA";
            int[] X = { 2, -1, -4, -3, 3 };
            int[] Y = { 2, -2, 4, 1, -3 };

            MaxPoints mp = new MaxPoints();
            Console.WriteLine(mp.solution(S, X, Y));

            //MakePalindrome mp = new MakePalindrome();
            //Console.WriteLine(mp.solution("?a?"));
        }
    }
}
