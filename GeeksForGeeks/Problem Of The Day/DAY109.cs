using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY109
    {
        //Coverage of all Zeros in a Binary Matrix
        //problem link=>>https://www.geeksforgeeks.org/problems/coverage-of-all-zeros-in-a-binary-matrix4024/1
    }
    //class Solution
    //{
    //    public int findCoverage(int[][] mat)
    //    {
    //        // code here
    //        int c = 0;
    //        for (int i = 0; i < mat.length; i++)
    //        {
    //            for (int j = 0; j < mat[0].length; j++)
    //            {
    //                if (mat[i][j] == 0)
    //                {
    //                    if (i - 1 > -1 && mat[i - 1][j] == 1)
    //                        c++;
    //                    if (i + 1 < mat.length && mat[i + 1][j] == 1)
    //                        c++;
    //                    if (j - 1 > -1 && mat[i][j - 1] == 1)
    //                        c++;
    //                    if (j + 1 < mat[0].length && mat[i][j + 1] == 1)
    //                        c++;
    //                }
    //            }
    //        }
    //        return c;
    //    }
    //}
}
