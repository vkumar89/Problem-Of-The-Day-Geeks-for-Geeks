﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{

    internal class DAY4
    {
        //day 4 problem =>> Print matrix in diagonal pattern

        //problem link =>> https://www.geeksforgeeks.org/problems/print-matrix-in-diagonal-pattern/1
        static int MAX = 100;

        static void printMatrixDiagonal(int[,] mat, int n)
        {
            // Initialize indexes of element to be printed next 
            int i = 0, j = 0;

            // Direction is initially from down to up 
            bool isUp = true;

            // Traverse the matrix till all elements get traversed 
            for (int k = 0; k < n * n;)
            {
                // If isUp = true then traverse from downward 
                // to upward 
                if (isUp)
                {
                    for (; i >= 0 && j < n; j++, i--)
                    {
                        Console.Write(mat[i, j] + " ");
                        k++;
                    }

                    // Set i and j according to direction 
                    if (i < 0 && j <= n - 1)
                        i = 0;
                    if (j == n)
                    {
                        i = i + 2;
                        j--;
                    }
                }

                // If isUp = 0 then traverse up to down 
                else
                {
                    for (; j >= 0 && i < n; i++, j--)
                    {
                        Console.Write(mat[i, j] + " ");
                        k++;
                    }

                    // Set i and j according to direction 
                    if (j < 0 && i <= n - 1)
                        j = 0;
                    if (i == n)
                    {
                        j = j + 2;
                        i--;
                    }
                }

                // Revert the isUp to change the direction 
                isUp = !isUp;
            }

        }
        public static void Main()
        {
            int[,] mat = { { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 } };

            int n = 3;
            printMatrixDiagonal(mat, n);
        }
    }
}
