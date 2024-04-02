using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY24
    {
        //Minimum Absolute Difference In BST
        //problem link =>>https://www.geeksforgeeks.org/problems/minimum-absolute-difference-in-bst-1665139652/1
    }
    //class Solution
    //{

    //    int absolute_diff(Node root)
    //    {
    //        int prev[] = { -1 };
    //        int min[] = { Integer.MAX_VALUE };
    //        inorder(root, prev, min);
    //        return min[0];
    //    }
    //    static void inorder(Node root, int prev[], int min[])
    //    {
    //        if (root == null) return;
    //        inorder(root.left, prev, min);
    //        if (prev[0] != -1)
    //        {
    //            min[0] = Math.min(min[0], Math.abs(prev[0] - root.data));
    //        }
    //        prev[0] = root.data;
    //        inorder(root.right, prev, min);//Your code here
    //    }
    //}
}
