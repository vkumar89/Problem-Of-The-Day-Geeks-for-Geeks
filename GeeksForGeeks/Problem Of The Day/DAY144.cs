using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY144
    {
        //Longest Common Prefix of Strings
        //problem link =>>https://www.geeksforgeeks.org/problems/longest-common-prefix-in-an-array5129/1
    }
    //class Solution
    //{
    //    public String longestCommonPrefix(String arr[])
    //    {
    //        String res = "";
    //        int len = arr.length;
    //        for (int i = 0; i < arr[0].length(); i++)
    //        {
    //            char tar = arr[0].charAt(i);
    //            if (check(arr, tar, i))
    //            {
    //                res += tar;
    //            }
    //            else break;
    //        }
    //        return res.length() > 0 ? res : "-1";
    //    }
    //    public boolean check(String[] arr, char tar, int ind)
    //    {
    //        for (int i = 1; i < arr.length; i++)
    //        {
    //            if (ind >= arr[i].length() || arr[i].charAt(ind) != tar) return false;
    //        }
    //        return true;
    //    }
    //}
}
