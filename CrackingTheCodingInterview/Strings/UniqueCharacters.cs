using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class UniqueCharacters
    {
        public bool IsUnique(string input)
        {
            HashSet<char> characters = new HashSet<char>();
            foreach(char c in input.ToCharArray())
            {
                if (characters.Contains(c))
                    return false;

                characters.Add(c);
            }

            return true;
        }

        public bool IsUnique_Long(string input)
        {
            for (int i = 0; i < input.Length; i++)
                for (int j = i + 1; j < input.Length; j++)
                    if (input[i].Equals(input[j]))
                        return false;
            return true;
        }
    }
}
