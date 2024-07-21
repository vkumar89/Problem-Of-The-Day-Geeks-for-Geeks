using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem_Of_The_Day
{
    internal class DAY134
    {
        //Maximum product subset of an array

        //problem link =>>https://www.geeksforgeeks.org/problems/maximum-product-subset-of-an-array/1
    }
    //class Solution
    //{
    //    public long findMaxProduct(List<Integer> al)
    //    {
    //        int MOD = 1000000007;
    //        if (al.size() == 1)
    //            return al.get(0) % MOD;


    //        boolean posExists = false;
    //        int negativeCount = 0;
    //        int maxNegNumber = Integer.MIN_VALUE;
    //        int zeros = 0;
    //        long product = 1;
    //        int minNegNumber = Integer.MIN_VALUE;

    //        for (Integer e : al)
    //        {
    //            if (e > 0)
    //            {
    //                posExists = true;
    //                product = (product * e) % MOD;
    //            }
    //            else if (e < 0)
    //            {
    //                negativeCount++;
    //                maxNegNumber = Math.max(e, maxNegNumber);
    //                if (minNegNumber == Integer.MIN_VALUE || e > minNegNumber)
    //                    minNegNumber = e;

    //                product = (product * e) % MOD;
    //            }
    //            else
    //                zeros++;

    //        }

    //        if (zeros == al.size())
    //            return 0;


    //        if (negativeCount % 2 != 0)
    //        {
    //            if (negativeCount == 1 && zeros > 0 && !posExists)
    //            {
    //                return 0;
    //            }
    //            product = product / minNegNumber;
    //        }

    //        return product % MOD;
    //    }
    //}


}
