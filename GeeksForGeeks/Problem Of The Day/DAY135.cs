﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY135
    {
        //Largest BST
        //problem link =>>https://www.geeksforgeeks.org/problems/largest-bst/1
    }
    //class Info
    //{
    //    int minVal;
    //    int maxVal;
    //    int size;

    //    Info(int mi, int ma, int s)
    //    {
    //        minVal = mi;
    //        maxVal = ma;
    //        size = s;
    //    }
    //}

    //class Solution
    //{
    //    // Return the size of the largest sub-tree which is also a BST
    //    static int largestBst(Node root)
    //    {
    //        return solve(root).size;
    //    }

    //    static Info solve(Node root)
    //    {

    //        if (root == null) return new Info(Integer.MAX_VALUE, Integer.MIN_VALUE, 0);

    //        Info left = solve(root.left);
    //        Info right = solve(root.right);

    //        if (left.maxVal < root.data && root.data < right.minVal)
    //        {
    //            return new Info(Math.min(root.data, left.minVal), Math.max(root.data, right.maxVal), left.size + right.size + 1);
    //        }

    //        return new Info(Integer.MIN_VALUE, Integer.MAX_VALUE, Math.max(left.size, right.size));

    //    }

    //}
}
