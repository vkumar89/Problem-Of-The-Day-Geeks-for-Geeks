using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY119
    {
        //Populate Inorder Successor for all nodes
        //problem link =>>https://www.geeksforgeeks.org/problems/populate-inorder-successor-for-all-nodes/1
    }
    //class Solution
    //{
    //    public void populateNext(Node root)
    //    {

    //        // code here
    //        if (root == null) return;

    //        Node[] node = new Node[1];
    //        node[0] = new Node(-1);

    //        inorder(root, node);
    //    }

    //    private void inorder(Node root, Node[] node)
    //    {
    //        if (root.left != null)
    //        {
    //            inorder(root.left, node);
    //        }

    //        node[0].next = root;
    //        node[0] = root;

    //        if (root.right != null)
    //        {
    //            inorder(root.right, node);
    //        }

    //    }
    //}
}
