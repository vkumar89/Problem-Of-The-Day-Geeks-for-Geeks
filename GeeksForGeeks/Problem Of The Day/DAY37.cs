using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY37
    {
        //Count the elements

        //problem link =>>https://www.geeksforgeeks.org/problems/count-the-elements1529/1
    }
    //class Solution
    //{
    //    public static int[] countElements(int a[], int b[], int n, int query[], int q)
    //    {
    //        Arrays.sort(b);

    //        int[] ans = new int[q];

    //        for (int i = 0; i < q; i++)
    //        {
    //            ans[i] = count(b, a[query[i]]);
    //        }
    //        return ans;
    //    }

    //    public static int count(int[] arr, int val)
    //    {
    //        int start = 0, end = arr.length;

    //        while (start < end)
    //        {
    //            int mid = start + (end - start) / 2;
    //            if (arr[mid] <= val)
    //            {
    //                start = mid + 1;
    //            }
    //            else
    //            {
    //                end = mid;
    //            }
    //        }
    //        return start;
    //    }
    //}
}
