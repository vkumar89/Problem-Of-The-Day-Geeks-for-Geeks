﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY46
    {
        //Paths to reach origin

        //problem link =>>https://www.geeksforgeeks.org/problems/paths-to-reach-origin3850/1
    }
    class Solution5
    {
        //Complete this function
        public int ways(int n, int m)
        {

            int[,] dp = new int[n + 1, m + 1];
            for (int i = 0; i <= n; i++)
            {
                dp[i, 0] = 1;
            }
            for (int i = 0; i <= m; i++)
            {
                dp[0, i] = 1;
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    dp[i, j] = (dp[i - 1, j] + dp[i, j - 1]) % 1000000007;
                }
            }
            return dp[n, m];
        }
    }
}
