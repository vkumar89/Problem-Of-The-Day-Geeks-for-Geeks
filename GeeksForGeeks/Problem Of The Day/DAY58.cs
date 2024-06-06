using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY58
    {
        //Print all nodes that don't have sibling
        //problem link =>> https://www.geeksforgeeks.org/problems/print-all-nodes-that-dont-have-sibling/1
    }
    //class Tree
    //{
    //    ArrayList<Integer> noSibling(Node node)
    //    {
    //        // code here
    //        ArrayList<Integer> list = new ArrayList<>();
    //        ArrayList<Integer> toReturn = helper(list, node);
    //        if (toReturn.size() == 0)
    //        {
    //            toReturn.add(-1);
    //            return toReturn;
    //        }
    //        Collections.sort(toReturn);
    //        return toReturn;
    //    }
    //    private static ArrayList<Integer> helper(ArrayList<Integer> list, Node root)
    //    {
    //        if (root == null)
    //        {
    //            return list;
    //        }
    //        if (root.left != null && root.right == null)
    //        {
    //            list.add(root.left.data);
    //        }
    //        if (root.left == null && root.right != null)
    //        {
    //            list.add(root.right.data);
    //        }
    //        helper(list, root.left);
    //        helper(list, root.right);

    //        return list;
    //    }
    //}

}
