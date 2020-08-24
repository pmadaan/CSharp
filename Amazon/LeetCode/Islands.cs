//https://leetcode.com/problems/number-of-islands/

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCode
{
    class Islands
    {
        public int NumIslands(char[,] grid)
        {
            int m = grid.GetLength(0);
            int n = grid.GetLength(1);
            int count = 0;

            for(int i=0; i<m; i++)
            {
                for (int j = 0; j < n; j++)
                    if (grid[i,j] == '1')
                    {
                        getC(grid, i, j);
                        count++;
                    }
            }

            return count;
        }

        private void getC(char[,] grid, int i, int j)
        {
            if (i < 0 || i >= grid.GetLength(0) || j < 0 || j >= grid.GetLength(1) || grid[i,j] == '0') return;

            grid[i,j] = '0';
            getC(grid, i, j + 1);
            getC(grid, i, j - 1);
            getC(grid, i + 1, j);
            getC(grid, i - 1, j);
        }
    }
}
