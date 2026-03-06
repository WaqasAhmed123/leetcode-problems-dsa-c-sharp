using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Matrix
{
    public class RichestCustomerWealth_Problem_1672
    {
        public int MaximumWealth(int[][] accounts)
        {
            int richestWealth = 0;
            for (var i = 0; i < accounts.Length; i++)
            {
                int currentWealth = 0;
                for (var j = 0; j < accounts[i].Length; j++)
                {
                    currentWealth += accounts[i][j];
                }
                if (richestWealth < currentWealth)
                {
                    richestWealth = currentWealth;
                }
            }
            return richestWealth;
        }
    }
}
