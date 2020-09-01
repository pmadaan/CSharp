using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    class MatrixRotation
    {
        public void rotate(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            if (n != m) return;

            int mid = n / 2;

            while(mid > 0)
            {
                rotate(matrix, n, mid);
                mid--;
            }
        }

        private void rotate(int[,] matrix, int n, int mid)
        {
            int low = mid - 1;
            int high = n - mid;
            
            for(int i = low; i < high; i++)
            {
                int j = i - low;
                int t = matrix[low, i];
                matrix[low, i] = matrix[high-j, low]; // left -> top
                matrix[high - j, low] = matrix[high, high - j]; //bottom -> left
                matrix[high, high - j] = matrix[i, high]; // right -> bottom
                matrix[i, high] = t; //saved top -> right
            }
        }
    }
}
