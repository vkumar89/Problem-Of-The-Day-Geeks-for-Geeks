﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY79
    {
        //Longest subsequence-1
        //problem link =>>https://www.geeksforgeeks.org/problems/longest-subsequence-such-that-difference-between-adjacents-is-one4724/1
    }

    //class Solution
    //{
    //    public static int longestSubseq(int n, int[] a)
    //    {
    //        // code here
    //        int dp[] = new int[n];
    //        for (int i = 1; i < n; i++)
    //        {
    //            for (int j = 0; j < i; j++)
    //            {
    //                if (Math.abs(a[i] - a[j]) == 1)
    //                {
    //                    dp[i] = Math.max(dp[i], dp[j] + 1);
    //                }
    //            }
    //        }
    //        int ans = 0;
    //        for (int u = 0; u < n; u++)
    //        {
    //            if (dp[u] > ans) ans = dp[u];
    //        }
    //        return ans + 1;
    //    }
    //}
}
