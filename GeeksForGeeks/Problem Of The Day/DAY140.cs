﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY140
    {
        //Form a palindrome
        //problem link=>>https://www.geeksforgeeks.org/problems/form-a-palindrome1455/1
    }
    //class Solution
    //{
    //    static int countMin(String str)
    //    {
    //        int[][] dp = new int[str.length()][str.length()];
    //        for (int[] arr : dp)
    //            Arrays.fill(arr, -1);

    //        String rev = new StringBuilder(str).reverse().toString();
    //        return str.length() - solve(0, 0, str, rev, dp);
    //    }
    //    public static int solve(int i, int j, String str, String rev, int[][] dp)
    //    {
    //        if (i == str.length() || j == rev.length())
    //            return 0;
    //        if (dp[i][j] != -1)
    //            return dp[i][j];

    //        if (str.charAt(i) == rev.charAt(j))
    //            dp[i][j] = 1 + solve(i + 1, j + 1, str, rev, dp);

    //        else

    //            dp[i][j] = Math.max(solve(i + 1, j, str, rev, dp),
    //            solve(i, j + 1, str, rev, dp));

    //        return dp[i][j];

    //    }
    //}
}
