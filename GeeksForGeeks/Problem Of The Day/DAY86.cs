﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY86
    {
        //Trail of ones
        //problem link =>> https://www.geeksforgeeks.org/problems/trail-of-ones3242/1
    }
    //class Solution
    //{
    //    static int numberOfConsecutiveOnes(int n)
    //    {
    //        int MOD = 1000000007;

    //        int[] dp = new int[n + 1];

    //        dp[0] = 0;
    //        dp[1] = 0;
    //        dp[2] = 1;

    //        if (n < 3)
    //        {
    //            return dp[n];
    //        }

    //        int a = 0;
    //        int b = 1;

    //        for (int i = 3; i <= n; i++)
    //        {
    //            int c = (a + b) % MOD;
    //            dp[i] = (dp[i - 1] * 2) % MOD + c % MOD;
    //            dp[i] = dp[i] % MOD;
    //            a = b;
    //            b = c;
    //        }
    //        return dp[n];
    //    }
    //}
}
