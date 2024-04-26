using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY48
    {
        //Exit Point in a Matrix

        //problem link =>>https://www.geeksforgeeks.org/problems/exit-point-in-a-matrix0905/1

    }
    //class Solution
    //{
    //    int x = 0, y = 0;
    //    public int[] FindExitPoint(int n, int m, int[][] matrix)
    //    {
    //        // code here
    //        char dir = 'e';
    //        helper(matrix, 0, 0, dir);
    //        return new int[] { x, y };
    //    }

    //    private void helper(int[][] mat, int r, int c, char dir)
    //    {
    //        if (r >= mat.length || r < 0 || c < 0 || c >= mat[0].length)
    //        {
    //            return;
    //        }
    //        x = r; y = c;
    //        if (mat[r][c] == 0)
    //        {
    //            if (dir == 'n') helper(mat, r - 1, c, dir);
    //            else if (dir == 's') helper(mat, r + 1, c, dir);
    //            else if (dir == 'w') helper(mat, r, c - 1, dir);
    //            else if (dir == 'e') helper(mat, r, c + 1, dir);
    //        }
    //        else
    //        {
    //            mat[r][c] = 0;
    //            if (dir == 'n') helper(mat, r, c + 1, 'e');
    //            else if (dir == 's') helper(mat, r, c - 1, 'w');
    //            else if (dir == 'w') helper(mat, r - 1, c, 'n');
    //            else if (dir == 'e') helper(mat, r + 1, c, 's');
    //        }

    //    }
    //}
}
