using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY108
    {
        //Left Rotate Matrix K times
        //problem link =>>https://www.geeksforgeeks.org/problems/left-rotate-matrix-k-times2351/1
    }
    //class Solution
    //{
    //    int[][] rotateMatrix(int k, int mat[][])
    //    {
    //        // code here

    //        int row = mat.length;
    //        int column = mat[0].length;

    //        k = k % column;

    //        if (k == 0) return mat;

    //        while (k-- != 0)
    //        {

    //            int temp[] = new int[row];

    //            for (int i = 0; i < row; i++)
    //            {
    //                temp[i] = mat[i][0];
    //            }

    //            for (int i = 0; i < row; i++)
    //            {
    //                for (int j = 0; j < column - 1; j++)
    //                {
    //                    mat[i][j] = mat[i][j + 1];
    //                }
    //            }

    //            for (int i = 0; i < row; i++)
    //            {
    //                mat[i][column - 1] = temp[i];
    //            }


    //        }

    //        return mat;
    //    }
    //}
}
