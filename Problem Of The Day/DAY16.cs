using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY16
    {
        //problem =>>Print N-bit binary numbers having more 1s than 0s
        //problem link =>> https://www.geeksforgeeks.org/problems/print-n-bit-binary-numbers-having-more-1s-than-0s0252/1
    }
    //class Solution
    //{
    //    void solve(String ds, int ones, int remaining, ArrayList<String> res)
    //    {
    //        if (remaining == 0)
    //        {
    //            res.add(ds);
    //            return;
    //        }

    //        solve(ds + "1", ones + 1, remaining - 1, res);
    //        if (ones > 0)
    //            solve(ds + "0", ones - 1, remaining - 1, res);
    //    }

    //    ArrayList<String> NBitBinary(int n)
    //    {
    //        ArrayList<String> res = new ArrayList<>();
    //        String ds = "";
    //        solve(ds, 0, n, res);
    //        return res;
    //    }
    //}
}
