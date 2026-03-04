using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class SpecialPositions_Problem_1582
    {
        public int NumSpecial(int[][] mat)
        {
            int totalSpecial = 0;
            for (int i = 0; i < mat.Length; i++)
            {

                bool isRowConsiderable = mat[i].Count(x => x == 1) == 1;
                if (!isRowConsiderable) continue;

                int index = Array.IndexOf(mat[i], 1);
                bool isSpecial = true;
                for (int j = 0; j < mat.Length; j++)
                {
                    isSpecial = true;
                    if (mat[j][index] == 1 && j != i)
                    {
                        isSpecial = false;
                        break;
                    }
                }
                if (isSpecial)
                    totalSpecial++;
            }
            return totalSpecial;
        }
    }
}
