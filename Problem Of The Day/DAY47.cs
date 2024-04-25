using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY47
    {
        //Maximum sum of hour glass

        //problem link =>>  https://www.geeksforgeeks.org/problems/maximum-sum-of-hour-glass3842/1
    }
    //class Solution
    //{
    //    int findMaxSum(int n, int m, int mat[][])
    //    {
    //        if (n < 3 || m < 3) return -1;
    //        int max = -1;
    //        for (int i = 0; i < n; i++)
    //        {
    //            for (int j = 0; j < m; j++)
    //            {
    //                max = Math.max(max, solve(i, j, n, m, mat));
    //            }
    //        }
    //        return max;
    //    }
    //    static int solve(int i, int j, int n, int m, int mat[][])
    //    {
    //        if (j - 1 < 0 || j + 1 >= m || i + 1 >= n || i + 2 >= n) return -1;
    //        int ans = mat[i][j];
    //        ans += mat[i][j - 1] + mat[i][j + 1] + mat[i + 1][j] + mat[i + 2][j] + mat[i + 2][j + 1] + mat[i + 2][j - 1];
    //        return ans;
    //    }
    //}
}
