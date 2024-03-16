using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem_Of_The_Day
{
    internal class DAY7
    {
        static void Main()
        {
            //Delete without head pointer

            //problem link=>> https://www.geeksforgeeks.org/problems/delete-without-head-pointer/1
        }


    }
    class Solution
    {

        //Complete this function
        public void deleteNode(Node del_node)
        {
            del_node.data = del_node.next.data;
            del_node.next = del_node.next.next;
        }
    }
    public class Node
    {
        public int data;
        public Node next;

        public Node(int a)
        {
            this.data = a;
            this.next = null;
        }

    }
}
