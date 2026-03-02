using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class LuckyNumber_Problem_1380
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            List<int> luckyNumbers = new List<int>();

            for (var row = 0; row < matrix.Length; row++)
            {
                int min = matrix[row].Min();
                int colIndex = Array.IndexOf(matrix[row], min);
                List<int> columnValues = new List<int>();
                for (var col = 0; col < matrix.Length; col++)
                {
                    columnValues.Add(matrix[col][colIndex]);
                }
                if (columnValues != null && columnValues.Any() && columnValues.Max() == min)
                    luckyNumbers.Add(min);
            }
            return luckyNumbers;
        }
    }
}
