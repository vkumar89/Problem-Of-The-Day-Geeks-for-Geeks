﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    //Largest subsquare surrounded by X

    //problem link=>> https://www.geeksforgeeks.org/problems/largest-subsquare-surrounded-by-x0558/1 

    internal class DAY5
    {
        //int largestSubsquare(int n, char a[][])
        //{
        //    // code here
        //    int[][] top = new int[n][n];
        //    int[][] left = new int[n][n];

        //    // Top metric
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (a[i][j] == 'X')
        //            {
        //                if (i != 0)
        //                    top[i][j] = top[i - 1][j] + 1;
        //                else
        //                    top[i][j] = 1;
        //            }
        //        }
        //    }

        //    // Left metric
        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (a[i][j] == 'X')
        //            {
        //                if (j != 0)
        //                    left[i][j] = left[i][j - 1] + 1;
        //                else
        //                    left[i][j] = 1;
        //            }
        //        }
        //    }

        //    int maxSubSq = 0;

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j < n; j++)
        //        {
        //            if (top[i][j] == 0 || left[i][j] == 0)
        //                continue;

        //            int currentValue = Math.min(top[i][j], left[i][j]);

        //            while (currentValue > 0)
        //            {
        //                int top1 = i - currentValue + 1;
        //                int left1 = j - currentValue + 1;

        //                if ((left[top1][j] >= currentValue) && (top[i][left1] >= currentValue))
        //                {
        //                    maxSubSq = Math.max(maxSubSq, currentValue);
        //                    break;
        //                }

        //                currentValue--;
        //            }
        //        }
        //    }

        //    return maxSubSq;

        //}
    }
}
