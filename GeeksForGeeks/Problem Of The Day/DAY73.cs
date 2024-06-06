using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY73
    {
        //K closest elements
        //problem link =>> https://www.geeksforgeeks.org/problems/k-closest-elements3619/1
    }
    //class Solution
    //{
    //    public int findCrossOver(int[] arr, int low, int high, int x)
    //    {
    //        if (arr[high] <= x) return high;
    //        if (arr[low] > x) return low;

    //        int mid = (low + high) / 2;

    //        if (arr[mid] <= x && arr[mid + 1] > x) return mid;
    //        else if (arr[mid] < x) return findCrossOver(arr, mid + 1, high, x);
    //        return findCrossOver(arr, low, mid - 1, x);
    //    }
    //    public int[] printKClosest(int[] arr, int n, int k, int x)
    //    {
    //        int id1 = findCrossOver(arr, 0, n - 1, x);
    //        int id2 = id1 + 1;
    //        if (id1 >= 0 && arr[id1] == x) id1--;
    //        int[] ans = new int[k];
    //        int index = 0;
    //        for (int i = 0; i < k; i++)
    //        {
    //            if (id1 >= 0 && id2 < n)
    //            {
    //                int val1 = x - arr[id1];
    //                int val2 = arr[id2] - x;
    //                if (val1 < val2)
    //                {
    //                    ans[index++] = arr[id1];
    //                    id1--;
    //                }
    //                else
    //                {
    //                    ans[index++] = arr[id2];
    //                    id2++;
    //                }
    //            }
    //            else if (id1 >= 0)
    //            {
    //                ans[index++] = arr[id1];
    //                id1--;
    //            }
    //            else
    //            {
    //                ans[index++] = arr[id2];
    //                id2++;
    //            }
    //        }
    //        return ans;
    //    }

    //}

}
