using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRotation sr = new StringRotation();
            Console.WriteLine(sr.IsRotation("waterbottle", "erbottlewat"));

            //MatrixRotationTest();

            //ZeroMatrixTest();

            /*
            OneAway ow = new OneAway();
            Console.WriteLine(ow.IsIt("pale", "pale"));
            Console.WriteLine(ow.IsIt("pale", "bale"));
            Console.WriteLine(ow.IsIt("pale", "ple"));
            Console.WriteLine(ow.IsIt("pale", "pales"));
            Console.WriteLine(ow.IsIt("pale", "bake"));
            */

            /*
            Compression c = new Compression();
            Console.WriteLine(c.compress("aaabbbbccccaaa"));
            Console.WriteLine(c.compress("aabbccddee"));
            */

            /*
            PalindromePermutation pp = new PalindromePermutation();
            Console.WriteLine(pp.IsIt("taco cat"));
            Console.WriteLine(pp.IsIt("tactcoapapa"));
            Console.WriteLine(pp.IsIt("tactcoapapaa"));
            */

            /*
            Permutations p = new Permutations();
            Console.WriteLine(p.isPermutation("abcdef", "fedcba"));
            Console.WriteLine(p.isPermutation("abcdef", "fedcbg"));
            */

            /*
            UniqueCharacters uc = new UniqueCharacters();
            Console.WriteLine(uc.IsUnique_Long("abcdefa"));
            Console.WriteLine(uc.IsUnique_Long("abcdef"));
            Console.WriteLine(uc.IsUnique("abcdefghijkl"));
            Console.WriteLine(uc.IsUnique("abcdefa"));
            */
        }

        private static void MatrixRotationTest()
        {
            MatrixRotation mr = new MatrixRotation();
            int[,] input = new int[5, 5]
            {
                {2,3,0,5,6 },
                {1,2,3,4,7 },
                {3,4,5,6,8 },
                {0,4,5,6,9},
                {9,3,1,4,10}
            };

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                    Console.Write(input[i, j]);
                Console.WriteLine();
            }

            mr.rotate(input);
            Console.WriteLine();

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                    Console.Write(input[i, j]);
                Console.WriteLine();
            }
        }

        private static void ZeroMatrixTest()
        {
            ZeroMatrix zm = new ZeroMatrix();

            int[,] input = new int[5, 4]
            {
                {2,3,0,5 },
                {1,2,3,4 },
                {3,4,5,6 },
                {0,4,5,6},
                {9,3,1,4}
            };

            zm.convert(input);

            for(int i=0; i<input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                    Console.Write(input[i, j]);
                Console.WriteLine();
            }
        }
    }
}
