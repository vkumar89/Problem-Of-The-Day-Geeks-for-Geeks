﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY74
    {
        //Minimize Max Distance to Gas Station
        //problem link=>> https://www.geeksforgeeks.org/problems/minimize-max-distance-to-gas-station/1
    }
    //class Solution
    //{
    //    static double findSmallestMaxDist(int a[], int k)
    //    {
    //        int n = a.length;
    //        double l = 0, r = maxDist(a);
    //        while (l + 1e-6 < r)
    //        {
    //            double mid = (r + l) / 2;
    //            if (possible(a, n, k, mid))
    //            {
    //                r = mid;
    //            }
    //            else
    //            {
    //                l = mid;
    //            }
    //        }
    //        return r;
    //    }
    //    static boolean possible(int a[], int n, int k, double mid)
    //    {
    //        int req = 0;
    //        for (int i = 1; i < n; i++)
    //        {
    //            double diff = a[i] - a[i - 1];
    //            req += Math.ceil(diff / mid) - 1;
    //        }
    //        return req <= k;
    //    }
    //    static double maxDist(int a[])
    //    {
    //        int n = a.length;
    //        double maxDist = 0.0;
    //        for (int i = 1; i < n; i++) maxDist = Math.max(maxDist, a[i] - a[i - 1]);
    //        return maxDist;
    //    }
    //}
}
