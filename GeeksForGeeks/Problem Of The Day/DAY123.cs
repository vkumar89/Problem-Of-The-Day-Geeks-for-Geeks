﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY123
    {
        //Largest square formed in a matrix
        //problem link =>>https://www.geeksforgeeks.org/problems/largest-square-formed-in-a-matrix0806/1
    }
    //class Solution
    //{
    //    static int maxSquare(int n, int m, int mat[][])
    //    {
    //        // code here
    //        int res[][] = new int[n + 1][m + 1];
    //        int max = 0;
    //        for (int i = 1; i <= n; i++)
    //        {
    //            for (int j = 1; j <= m; j++)
    //            {
    //                if (mat[i - 1][j - 1] == 1)
    //                {
    //                    res[i][j] = 1 + Math.min(res[i - 1][j - 1], Math.min(res[i - 1][j], res[i][j - 1]));
    //                    max = Math.max(max, res[i][j]);

    //                }
    //            }
    //        }
    //        return max;
    //    }
    //}
}
