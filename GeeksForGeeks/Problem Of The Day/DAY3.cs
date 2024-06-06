using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY3
    {
        // Generalised Fibonacci numbers

        //Method one 
        // problem Link =>>https://www.geeksforgeeks.org/problems/generalised-fibonacci-numbers1820/1

        //Complete this function
        //public long genFibNum(long a, long b, long c, long n, long m)
        //{
        //    long g1 = 1;
        //    long g2 = 1;
        //    long res = 1;
        //    for (int i = 3; i <= n; i++)
        //    {
        //        res = a * (g2) + b * (g1) + c;
        //        long temp = g2;
        //        g2 = res;
        //        g1 = temp;

        //    }
        //    return res % m;
        //}
        //class Solution
        //{
        //    static long genFibNum(long a, long b, long c, long n, long m)
        //    {
        //        // code here
        //        if (n <= 2)
        //        {
        //            return 1 % m;
        //        }
        //        long[][] mat = {
        //        {a, b, 1},
        //        {1, 0, 0},
        //        {0, 0, 1}
        //};
        //        long[][] res = {
        //        {1, 0, 0},
        //        {0, 1, 0},
        //        {0, 0, 1}
        //};
        //        n -= 2;
        //        while (n > 0)
        //        {
        //            if ((n & 1) == 1)
        //            {
        //                res = multiply(res, mat, m);
        //            }
        //            mat = multiply(mat, mat, m);
        //            n >>= 1;
        //        }
        //        return (res[0][0] + res[0][1] + c * res[0][2]) % m;
        //    }
        //    static long[][] multiply(long[][] A, long[][] B, long m)
        //    {
        //        int size = A.Length;
        //        long[][] result = new long[size][size];
        //        for (int i = 0; i < size; ++i)
        //        {
        //            for (int j = 0; j < size; ++j)
        //            {
        //                long sum = 0;
        //                for (int k = 0; k < size; ++k)
        //                {
        //                    sum += A[i][k] * B[k][j];
        //                    sum %= m;
        //                }
        //                result[i][j] = sum;
        //            }
        //        }
        //        return result;
        //    }
        //};




    }
}
