﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY100
    {
        //Check If two Line segments Intersect
        //problem link =>>https://www.geeksforgeeks.org/problems/check-if-two-line-segments-intersect0017/1
    }
    //class Solution
    //{
    //    String doIntersect(int p1[], int q1[], int p2[], int q2[])
    //    {
    //        int o1 = orientation(p1, q1, p2);
    //        int o2 = orientation(p1, q1, q2);
    //        int o3 = orientation(p2, q2, p1);
    //        int o4 = orientation(p2, q2, q1);

    //        if (o1 != o2 && o3 != o4) return "true";
    //        if (o1 == 0 && onSegment(p1, q1, p2)) return "true";
    //        if (o2 == 0 && onSegment(p1, q1, q2)) return "true";
    //        if (o3 == 0 && onSegment(p2, q2, p1)) return "true";
    //        if (o4 == 0 && onSegment(p2, q2, q1)) return "true";
    //        return "false";
    //    }
    //    private boolean onSegment(int[] p, int[] q, int[] r)
    //    {
    //        return r[0] <= Math.max(p[0], q[0]) && r[0] >= Math.min(p[0], q[0]) &&
    //               r[1] <= Math.max(p[1], q[1]) && r[1] >= Math.min(p[1], q[1]);
    //    }

    //    private int orientation(int[] p, int[] q, int[] r)
    //    {
    //        long val = (long)(q[1] - p[1]) * (r[0] - q[0]) - (long)(q[0] - p[0]) * (r[1] - q[1]);
    //        if (val == 0)
    //        {
    //            return 0;
    //        }
    //        return (val > 0) ? 1 : 2;
    //    }
    //}
}
