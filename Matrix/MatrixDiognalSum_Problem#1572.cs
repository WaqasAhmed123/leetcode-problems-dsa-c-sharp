using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class MatrixDiognalSum_Problem_1572
    {
        public int DiagonalSum(int[][] mat)
        {
            bool isEven = mat.Length % 2 == 0;
            var sum = 0;
            var crossIndex = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i];
            }
            for (int j = mat.Length - 1; j >= 0; j--)
            {
                if (!isEven && j == mat.Length / 2)
                {
                    crossIndex++;
                    continue;
                }
                else
                    sum += mat[j][crossIndex];
                crossIndex++;
            }
            return sum;
        }
    }
}
