using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY8
    {
        //Count Pairs whose sum is equal to X
        //problem =>> https://www.geeksforgeeks.org/problems/count-pairs-whose-sum-is-equal-to-x/1
    }
    class Solution1
    {
        //Complete this function
        public int countPairs(Node head1, Node head2, int x)
        {
            HashSet<int> set = new HashSet<int>();

            // Traverse the second list and store its elements in a set
            Node temp = head2;
            while (temp != null)
            {
                set.Add(temp.data);
                temp = temp.next;
            }

            int count = 0;

            // Traverse the first list and for each element, check if its complement exists in the set
            temp = head1;
            while (temp != null)
            {
                if (set.Contains(x - temp.data))
                {
                    count++;
                }
                temp = temp.next;
            }

            return count;
            //Your code here

        }
    }
}
