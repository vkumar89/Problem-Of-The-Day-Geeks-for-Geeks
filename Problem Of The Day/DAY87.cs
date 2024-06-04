using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY87
    {
        //Binary representation of next number
        //problem link =>> https://www.geeksforgeeks.org/problems/binary-representation-of-next-number3648/1
    }
    //class Solution
    //{
    //    public String binaryNextNumber(String s)
    //    {
    //        char carry = '1';

    //        StringBuilder ans = new StringBuilder();

    //        for (int i = s.length() - 1; i >= 0; i--)
    //        {
    //            if (carry == '1')
    //            {
    //                if (s.charAt(i) == '0')
    //                {
    //                    ans.append('1');
    //                    carry = '0';
    //                }
    //                else
    //                {
    //                    ans.append('0');
    //                }
    //            }
    //            else
    //            {
    //                ans.append(s.charAt(i));
    //            }
    //        }

    //        if (carry == '1')
    //        {
    //            ans.append('1');
    //        }

    //        while (ans.length() > 1 && ans.charAt(ans.length() - 1) == '0')
    //        {
    //            ans.deleteCharAt(ans.length() - 1);
    //        }

    //        return ans.reverse().toString();
    //    }

    //}
}
