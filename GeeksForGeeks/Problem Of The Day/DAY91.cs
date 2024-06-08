using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY91
    {
        //Index of an Extra Element
        //problem link =>>https://www.geeksforgeeks.org/problems/index-of-an-extra-element/1
    }
    //class Solution
    //{
    //    public int findExtra(int n, int arr1[], int arr2[])
    //    {
    //        // add code here.
    //        int low = 0, high = n - 1;
    //        if (arr2.length == 0)
    //            return 0;
    //        if (arr1[0] != arr2[0])
    //            return 0;
    //        if (arr1[n - 1] != arr2[n - 2])
    //            return n - 1;
    //        while (low <= high)
    //        {
    //            int mid = low + (high - low) / 2;
    //            if (arr1[mid] == arr2[mid])
    //            {
    //                low = mid + 1;
    //            }
    //            else if (arr1[mid + 1] == arr2[mid])
    //            {
    //                high = mid - 1;
    //            }
    //        }
    //        return low;
    //    }
    //}
}