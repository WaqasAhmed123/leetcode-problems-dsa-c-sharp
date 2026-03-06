using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class Convert1DArrayInto2DArray_Problem_2022
    {
        public int[][] Construct2DArray(int[] original, int m, int n)
        {
            if (m * n != original.Length) return [];

            int[][] result = new int[m][];

            //better version 
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = original[i * n + j];
                }
            }
            return result;


            //not ideal takes longer runtime.
            //List<List<int>> result = new List<List<int>>();

            //int indexCount = 0;
            //for (int i = 0; i < m; i++)
            //{
            //    List<int> sub = new List<int>();

            //    for (int j = 0; j < n; j++)
            //    {
            //        sub.Add(original[indexCount]);
            //        indexCount++;
            //    }

            //    result.Add(sub);
            //}

            //return result.Select(x => x.ToArray()).ToArray();

        }
    }
}
