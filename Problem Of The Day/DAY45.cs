using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY45
    {
        //Rohan's Love for Matrix

        //problem link =>>https://www.geeksforgeeks.org/problems/rohans-love-for-matrix4723/1

    }
    class Solution2
    {
        //Complete this function
        //Function to find the first element in the array.
        public int firstElement(int n)
        {

            // code here
            if (n == 1 || n == 2) return 1;
            if (n == 3) return 2;
            int a1 = 1, a2 = 2, a3 = 0;
            int i = 4;
            while (i <= n)
            {
                a3 = (a1 + a2) % 1000000007;
                a1 = a2;
                a2 = a3 % 1000000007;
                i++;
            }
            return a3 % (1000000007);
        }
    }

}
