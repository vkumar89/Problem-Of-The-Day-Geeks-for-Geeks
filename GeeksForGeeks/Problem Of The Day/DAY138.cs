using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY138
    {
        //Array to BST
        //problem link=>>https://www.geeksforgeeks.org/problems/array-to-bst4443/1
    }
    //class Solution
    //{
    //    public Node sortedArrayToBST(int[] nums)
    //    {
    //        return solve(0, nums.length - 1, nums);
    //    }
    //    public Node solve(int l, int r, int[] nums)
    //    {
    //        if (l > r)
    //            return null;
    //        int mid = l + (r - l) / 2;
    //        Node root = new Node(nums[mid]);
    //        root.left = solve(l, mid - 1, nums);
    //        root.right = solve(mid + 1, r, nums);

    //        return root;
    //    }
    //}
}
