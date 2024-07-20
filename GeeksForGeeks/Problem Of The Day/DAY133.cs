using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY133
    {
        //Remove Half Nodes
        //problem link =>>https://www.geeksforgeeks.org/problems/remove-half-nodes/1
    }
    //class Solution
    //{
    //    // Return the root of the modified tree after removing all the half nodes.
    //    public Node RemoveHalfNodes(Node root)
    //    {
    //        return findAns(root, null);
    //    }
    //    public Node findAns(Node root, Node parent)
    //    {
    //        if (root == null)
    //        {
    //            return null;
    //        }
    //        else if (root.left == null && root.right == null)
    //        {
    //            return root;
    //        }


    //        Node left = findAns(root.left, root);
    //        Node right = findAns(root.right, root);

    //        if (left != null && right != null)
    //        {
    //            return root;
    //        }
    //        else if (left == null)
    //        {
    //            if (parent == null)
    //            {
    //                return right;
    //            }
    //            else if (parent.left != null && parent.left == root)
    //            {
    //                parent.left = right;
    //            }
    //            else
    //            {
    //                parent.right = right;
    //            }
    //            return right;
    //        }
    //        else
    //        {
    //            if (parent == null)
    //            {
    //                return left;
    //            }
    //            else if (parent.left != null && parent.left == root)
    //            {
    //                parent.left = left;
    //            }
    //            else
    //            {
    //                parent.right = left;
    //            }
    //            return left;
    //        }
    //    }
    //}
}
