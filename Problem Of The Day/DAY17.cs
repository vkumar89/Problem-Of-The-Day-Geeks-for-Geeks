﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY17
    {
        //Additive sequence

        //problem link =>>https://www.geeksforgeeks.org/problems/additive-sequence/1
    }
    //class Solution
    //{
    //    public boolean isAdditiveSequence(String s)
    //    {
    //        // code here
    //        int n = s.length();
    //        int num1 = 0;
    //        for (int i = 0; i < n / 2; i++)
    //        {
    //            num1 = num1 * 10 + (s.charAt(i) - '0');
    //            int num2 = 0;
    //            for (int j = i + 1; j < n - 1; j++)
    //            {
    //                num2 = num2 * 10 + (s.charAt(j) - '0');
    //                int p2 = num1; int p1 = num2;
    //                int num = 0; int k = j + 1;
    //                while (k < n)
    //                {
    //                    num = num * 10 + (s.charAt(k) - '0');
    //                    if (num == (p1 + p2))
    //                    {
    //                        p2 = p1;
    //                        p1 = num;
    //                        num = 0;
    //                    }
    //                    k++;
    //                }
    //                if (k == n && num == 0) return true;
    //            }
    //        }
    //        return false;
    //    }
    //}
}
