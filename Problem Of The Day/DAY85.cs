using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY85
    {
        //Construct list using given q XOR queries
        //problem link =>> https://www.geeksforgeeks.org/problems/construct-list-using-given-q-xor-queries/1
    }


    //class Solution
    //{
    //    public static ArrayList<Integer> constructList(int q, int[][] queries)
    //    {
    //        ArrayList<Integer> ans = new ArrayList<>();
    //        int xor = 0;
    //        for (int i = q - 1; i >= 0; i--)
    //        {
    //            if (queries[i][0] == 0)
    //            {
    //                ans.add(queries[i][1] ^ xor);
    //            }
    //            else
    //            {
    //                xor = xor ^ queries[i][1];
    //            }
    //        }
    //        ans.add(0 ^ xor);
    //        Collections.sort(ans);
    //        return ans;
    //    }
    //}

}
