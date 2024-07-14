using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY127
    {
        //Segregate 0s and 1s
        //problem link =>>https://www.geeksforgeeks.org/problems/segregate-0s-and-1s5106/1
    }
    //class Solution
    //{
    //    public static void segregate0and1(int[] arr)
    //    {
    //        int left = 0, right = arr.length - 1;

    //        while (left < right)
    //        {
    //            while (arr[left] == 0 && left < right) left++;

    //            while (arr[right] == 1 && left < right)
    //                right--;

    //            if (left < right)
    //            {
    //                arr[left] = 0;
    //                arr[right] = 1;
    //                left++;
    //                right--;
    //            }
    //        }
    //    }


    //    public static void main(String[] args)
    //    {
    //        int[] arr1 = { 0, 0, 1, 1, 0 };
    //        segregate0and1(arr1);
    //        System.out.println(Arrays.toString(arr1));

    //        int[] arr2 = { 1, 1, 1, 1 };
    //        segregate0and1(arr2);
    //        System.out.println(Arrays.toString(arr2));
    //    }
    //}
}
