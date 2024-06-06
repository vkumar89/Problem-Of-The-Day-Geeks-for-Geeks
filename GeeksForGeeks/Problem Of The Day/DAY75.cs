using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY75
    {
        //K-Palindrome
        //problem link =>> https://www.geeksforgeeks.org/problems/find-if-string-is-k-palindrome-or-not1923/1
    }
    //class Solution
    //{
    //    public int kPalindrome(String str, int n, int k)
    //    {
    //        int[][] dp = new int[n][n];

    //        // Fill the DP table
    //        for (int length = 2; length <= n; length++)
    //        {  // Length of the substring
    //            for (int i = 0; i <= n - length; i++)
    //            {
    //                int j = i + length - 1;
    //                if (str.charAt(i) == str.charAt(j))
    //                {
    //                    dp[i][j] = dp[i + 1][j - 1];
    //                }
    //                else
    //                {
    //                    dp[i][j] = Math.min(dp[i + 1][j], dp[i][j - 1]) + 1;
    //                }
    //            }
    //        }

    //        // The result is in dp[0][n-1]
    //        return dp[0][n - 1] <= k ? 1 : 0;
    //    }
    //}
}
