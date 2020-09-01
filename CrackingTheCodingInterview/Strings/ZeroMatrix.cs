using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class ZeroMatrix
    {
        public void convert(int[,] input)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for(int i=0; i<input.GetLength(0); i++)
            {
                for(int j=0; j<input.GetLength(1); j++)
                    if(input[i,j] == 0)
                    {
                        if (map.ContainsKey(i))
                            map[i].Add(j);
                        else
                        {
                            List<int> temp = new List<int>();
                            temp.Add(j);
                            map[i] = temp;
                        }
                    }    
            }

            foreach(int row in map.Keys)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                    input[row, j] = 0;

                List<int> columns = map[row];
                foreach (int column in columns)
                    for (int i = 0; i < input.GetLength(0); i++)
                        input[i, column] = 0;
            }
        }
    }
}
