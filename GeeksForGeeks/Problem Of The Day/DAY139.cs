using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY139
    {
        //K-Pangrams
        //problem link =>>https://www.geeksforgeeks.org/problems/k-pangrams0909/1
    }
    //class Solution
    //{
    //    boolean kPangram(String str, int k)
    //    {
    //        int alphaCount = 0;
    //        int duplicatesCount = 0;
    //        HashSet<Character> alpha = new HashSet<>();

    //        for (int i = 0; i < str.length(); i++)
    //        {
    //            if (alpha.contains(str.charAt(i)))
    //            {
    //                duplicatesCount += 1;
    //            }
    //            else if (str.charAt(i) != ' ')
    //            {
    //                alpha.add(str.charAt(i));
    //            }
    //        }


    //        if (alpha.size() == 26 || ((26 - alpha.size() <= duplicatesCount) && (26 - alpha.size()) <= k))
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }

    //    }
    //}
}
