using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY116
    {
        //Remove all occurences of duplicates in a linked list
        //problem link =>>https://www.geeksforgeeks.org/problems/remove-all-occurences-of-duplicates-in-a-linked-list/1
    }
    //class Solution
    //{
    //    public Node removeAllDuplicates(Node head)
    //    {

    //        Node d = new Node(0);
    //        Node t1 = d;
    //        Node t = head;
    //        int p = -1;

    //        while (t != null)
    //        {
    //            if (t.next == null && p != t.data)
    //            {
    //                d.next = t;
    //                d = d.next;
    //                break;
    //            }

    //            if (t.next != null && t.data != t.next.data && p != t.data)
    //            {
    //                d.next = t;
    //                d = d.next;
    //            }
    //            p = t.data;
    //            t = t.next;
    //        }
    //        d.next = null;
    //        head = t1.next;
    //        return head;
    //    }
    //}
}
