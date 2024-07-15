using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY128
    {
        //Smallest number
        //problem link =>>https://www.geeksforgeeks.org/problems/smallest-number5829/1
    }
    //class Solution
    //{
    //    public String smallestNumber(int s, int d)
    //    {
    //        int i = (int)Math.pow(10, d - 1);
    //        while (true)
    //        {
    //            if (checkSum(i, s, d))
    //                return String.valueOf(i);
    //            if (String.valueOf(i).length() > d)
    //                break;

    //            i += 1;
    //        }
    //        return "-1";
    //    }
    //    static boolean checkSum(int i, int s, int d)
    //    {
    //        int len = String.valueOf(i).length();
    //        if (len == d)
    //        {
    //            int rem, sum = 0;
    //            while (i > 0)
    //            {
    //                rem = i % 10;
    //                sum += rem;
    //                i = i / 10;
    //            }
    //            if (sum == s)
    //            {
    //                return true;
    //            }
    //            return false;
    //        }
    //        return false;

    //    }
    //}
}
