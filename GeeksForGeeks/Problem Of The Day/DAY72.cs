using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY72
    {
        //Modular Exponentiation for large numbers

        // problem link=>> https://www.geeksforgeeks.org/problems/modular-exponentiation-for-large-numbers5537/1
    }

    //class Solution
    //{
    //    //Complete this function
    //    public long PowMod(long bas, long power, long m)
    //    {
    //        // Code here
    //        long ans = 1;
    //        while (power > 0)
    //        {
    //            if ((power & 1) == 1)
    //            {
    //                ans *= bas;
    //            }
    //            bas *= bas;
    //            bas %= m;
    //            power = power >> 1;
    //            ans = ans % m;
    //        }
    //        return ans;
    //    }
    //}
}
