using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY64
    {
        //Minimum steps to destination

        //problem link=>>https://www.geeksforgeeks.org/geeksforgeeks-master-sheet-list-of-all-cheat-sheets/?ref=footer
    }

    class Solution3
    {

        public int minSteps(int D)
        {
            int res = steps(D, 0, 0);
            return res;
        }
        static int steps(int d, int i, int j)
        {
            if (i - d >= 0 && (i - d) % 2 == 0)
            {
                return j;
            }
            j++;
            return steps(d, i + j, j);
        }
    }

}
