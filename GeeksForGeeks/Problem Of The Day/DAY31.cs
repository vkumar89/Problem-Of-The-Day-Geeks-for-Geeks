﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY31
    {
        //Minimum Points To Reach Destination
        //problem link =>>https://www.geeksforgeeks.org/problems/minimum-points-to-reach-destination0540/1
    }
    //class Solution
    //{
    //    public int minPoints(int points[][], int m, int n)
    //    {
    //        // Your code goes here
    //        int[][] dp = new int[m][n];
    //        dp[m - 1][n - 1] = Math.max(1, 1 - points[m - 1][n - 1]);
    //        for (int i = m - 1; i >= 0; i--)
    //        {
    //            for (int j = n - 1; j >= 0; j--)
    //            {
    //                if (i == m - 1 && j == n - 1)
    //                    continue; // Skip the destination cell
    //                int minPointsRequired = Integer.MAX_VALUE;
    //                if (i + 1 < m) // Move down
    //                    minPointsRequired = Math.min(minPointsRequired, dp[i + 1][j]);
    //                if (j + 1 < n) // Move right
    //                    minPointsRequired = Math.min(minPointsRequired, dp[i][j + 1]);
    //                dp[i][j] = Math.max(1, minPointsRequired - points[i][j]);
    //            }
    //        }
    //        return dp[0][0];
    //    }
    //}
}
