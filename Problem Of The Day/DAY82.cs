using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY82
    {
        //String Subsequence

        //problem link =>> https://www.geeksforgeeks.org/problems/find-number-of-times-a-string-occurs-as-a-subsequence3020/1
    }
    //class Solution
    //{
    //    public static int countWays(String s1, String s2)
    //    {
    //        int[][] dp = new int[s1.length()][s2.length()];
    //        for (int[] arr : dp)
    //            Arrays.fill(arr, -1);
    //        return solve(s1, s2, 0, 0, dp);
    //    }
    //    public static int solve(String s1, String s2, int i, int j, int[][] dp)
    //    {
    //        if (i == s1.length() && j == s2.length())
    //            return 1;
    //        if (i >= s1.length())
    //            return 0;
    //        if (j == s2.length())
    //            return 1;
    //        if (dp[i][j] != -1)
    //            return dp[i][j];

    //        if (s1.charAt(i) == s2.charAt(j))
    //            dp[i][j] = (solve(s1, s2, i + 1, j + 1, dp) + solve(s1, s2, i + 1, j, dp)) % 1000000007;
    //        else
    //            dp[i][j] = solve(s1, s2, i + 1, j, dp) % 1000000007;
    //        return dp[i][j];

    //    }
    //}


}
