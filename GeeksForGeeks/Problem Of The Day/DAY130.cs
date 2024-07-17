using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY130
    {
        //Construct Binary Tree from Parent Array
        //problem link=>>https://www.geeksforgeeks.org/problems/construct-binary-tree-from-parent-array/1
    }
    //class Solution
    //{
    //    public Node createTree(int parent[])
    //    {
    //        HashMap<Integer, Node> hm = new HashMap<>();
    //        Node root = null;
    //        for (int i = 0; i < parent.length; i++)
    //        {
    //            if (parent[i] == -1)
    //            {
    //                root = new Node(i);
    //                hm.put(i, root);
    //            }
    //            else
    //            {
    //                hm.put(i, new Node(i));
    //            }
    //        }
    //        for (int i = 0; i < parent.length; i++)
    //        {
    //            if (parent[i] == -1)
    //            {
    //                continue;
    //            }
    //            else
    //            {
    //                Node temp = hm.get(parent[i]);
    //                if (temp.left == null)
    //                {
    //                    temp.left = hm.get(i);
    //                }
    //                else
    //                {
    //                    temp.right = hm.get(i);
    //                }
    //            }
    //        }
    //        return root;
    //    }
    //}
}
