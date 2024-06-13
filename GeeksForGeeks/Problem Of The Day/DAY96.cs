using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY96
    {
        //Padovan Sequence
        //problem link =>>https://www.geeksforgeeks.org/problems/padovan-sequence2855/1
    }
    //class Solution
    //{
    //    private static final int MOD = 1000000007;

    //    public int padovanSequence(int n)
    //    {
    //        //code here.
    //        if (n == 0 || n == 1 || n == 2)
    //        {
    //            return 1;
    //        }

    //        // Dynamic programming array to store Padovan sequence values
    //        int[] dp = new int[n + 1];
    //        dp[0] = 1;
    //        dp[1] = 1;
    //        dp[2] = 1;

    //        // Compute Padovan values using the recurrence relation
    //        for (int i = 3; i <= n; i++)
    //        {
    //            dp[i] = (dp[i - 2] + dp[i - 3]) % MOD;
    //        }

    //        return dp[n];
    //    }

    //}
}
