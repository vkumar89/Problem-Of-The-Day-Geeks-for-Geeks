using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY105
    {
        //Extract the Number from the String
        //problem link=>>https://www.geeksforgeeks.org/problems/extract-the-number-from-the-string3428/1
    }
    //class Solution
    //{
    //    long ExtractNumber(String sentence)
    //    {
    //        String[] ar = sentence.split(" ");
    //        long ans = -1, max = -5;
    //        for (int i = 0; i < ar.length; i++)
    //        {
    //            boolean c = false;
    //            for (int j = 0; j < ar[i].length(); j++)
    //            {
    //                if (Character.isDigit(ar[i].charAt(j)))
    //                {
    //                    if (ar[i].charAt(j) != '9')
    //                    {
    //                        c = true;
    //                    }
    //                    else
    //                    {
    //                        c = false;
    //                        break;
    //                    }
    //                }
    //            }
    //            if (c)
    //                ans = Long.parseLong(ar[i]);
    //            if (ans > max)
    //            {
    //                max = ans;
    //            }
    //        }
    //        return max;
    //    }
    //}
}
