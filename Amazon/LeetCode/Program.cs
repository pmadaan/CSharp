using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ////https://leetcode.com/discuss/interview-question/542597/
            //keywordsTest(); 

            ////https://leetcode.com/discuss/interview-question/782606/
            //associationTest();

            ////https://leetcode.com/problems/search-suggestions-system/
            //suggestionsTest();

            //https://leetcode.com/problems/number-of-islands/
            islandsTest();
        }

        static void islandsTest()
        {
            Islands i = new Islands();
            char[,] grid = new char[,] {
                                { '1', '1', '1', '1', '0'},
                                { '1', '1', '0', '1', '0'},
                                { '1', '1', '0', '0', '0'},
                                { '0', '0', '0', '0', '0'}
            };

            Console.WriteLine(i.NumIslands(grid));

            grid = new char[,] {
                                { '1', '1', '0', '0', '0'},
                                { '1', '1', '0', '1', '0'},
                                { '0', '0', '1', '1', '0'},
                                { '0', '0', '0', '0', '1'}
            };

            Console.WriteLine(i.NumIslands(grid));
        }

        static void suggestionsTest()
        {
            Suggestions s = new Suggestions();

            string[] products = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";

            List<List<string>> suggestions = s.SuggestedProducts(products, searchWord);

            foreach (List<string> suggestion in suggestions)
            {
                suggestion.ForEach(i => Console.Write("{0}\t", i));
                Console.WriteLine();
            }

            products = new string[] { "havana"};
            searchWord = "havana";

            suggestions = s.SuggestedProducts(products, searchWord);

            foreach (List<string> suggestion in suggestions)
            {
                suggestion.ForEach(i => Console.Write("{0}\t", i));
                Console.WriteLine();
            }

            products = new string[] { "bags", "baggage", "banner", "box", "cloths" };
            searchWord = "bags";

            suggestions = s.SuggestedProducts(products, searchWord);

            foreach (List<string> suggestion in suggestions)
            {
                suggestion.ForEach(i => Console.Write("{0}\t", i));
                Console.WriteLine();
            }

        }

        static void associationTest()
        {
            Association s = new Association();

            List<PairString> input = new PairString[]{
                        new PairString("item1", "item2"),
                        new PairString("item3", "item4"),
                        new PairString("item4", "item5"),
                                                new PairString("item3", "item5")

                 }.ToList();

            List<string> largest = s.largestItemAssociation(input);
            largest.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            List<PairString> input2 = new PairString[] {
                        new PairString("item1","item2"),
                        new PairString("item2","item3"),
                        new PairString("item4","item5"),
                        new PairString("item6","item7"),
                        new PairString("item5","item6"),
                        new PairString("item3","item7")
                }.ToList();

            largest = s.largestItemAssociation(input2);
            largest.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            List<PairString> input3 = new PairString[] {
                        new PairString("item1","item2"),
                        new PairString("item1","item3"),
                        new PairString("item2","item7"),
                        new PairString("item3","item7"),
                        new PairString("item5","item6"),
                        new PairString("item3","item7")
                }.ToList();

            largest = s.largestItemAssociation(input3);
            largest.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

        }

        static void keywordsTest()
        {
            int k1 = 2;
            string[] keywords1 = { "anacell", "cetracular", "betacellular" };
            string[] reviews1 = { "Anacell provides the best services in the city", "betacellular has awesome services",
            "Best services provided by anacell, everyone should use anacell", };
            int k2 = 2;
            string[] keywords2 = { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" };
            string[] reviews2 = { "I love anacell Best services; Best services provided by anacell",
            "betacellular has great services", "deltacellular provides much better services than betacellular",
            "cetracular is worse than anacell", "Betacellular is better than deltacellular.", };

            List<string> l1 = Keywords.TopKFrequent(keywords1, reviews1, k1);
            l1.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();

            l1 = Keywords.TopKFrequent(keywords2, reviews2, k2);
            l1.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine();
        }
    }
}
