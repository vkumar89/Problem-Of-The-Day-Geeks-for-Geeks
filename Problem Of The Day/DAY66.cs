﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY66
    {
        //Path With Minimum Effort

        //problem link =>> https://www.geeksforgeeks.org/problems/path-with-minimum-effort/1
    }
    //class Solution
    //{

    //    int solve(int[][] heights)
    //    {

    //        int n = heights.length;
    //        int m = heights[0].length;

    //        int[][] dist = new int[n][m];
    //        for (int[] row : dist)
    //        {
    //            Arrays.fill(row, Integer.MAX_VALUE);
    //        }

    //        dist[0][0] = 0;
    //        PriorityQueue<int[]> pq = new PriorityQueue<>((a, b)->a[0] - b[0]);
    //        pq.offer(new int[] { 0, 0, 0 });

    //        int[][] dir = { { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 } };

    //        while (!pq.isEmpty())
    //        {

    //            int[] top = pq.poll();
    //            int diff = top[0];
    //            int x = top[1];
    //            int y = top[2];

    //            for (int[] d : dir)
    //            {

    //                int nx = x + d[0];
    //                int ny = y + d[1];

    //                if (nx >= 0 && nx < n && ny >= 0 && ny < m)
    //                {

    //                    int newDiff = Math.max(diff, Math.abs(heights[nx][ny] - heights[x][y]));

    //                    if (newDiff < dist[nx][ny])
    //                    {
    //                        dist[nx][ny] = newDiff;
    //                        pq.offer(new int[] { newDiff, nx, ny });
    //                    }
    //                }
    //            }
    //        }

    //        return dist[n - 1][m - 1];
    //    }

    //    public int MinimumEffort(int rows, int columns, int[][] heights)
    //    {

    //        return solve(heights);
    //    }
    //}
}
