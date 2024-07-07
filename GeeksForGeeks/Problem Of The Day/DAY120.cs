using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY120
    {
        //Ancestors in Binary Tree
        //problem link =>>https://www.geeksforgeeks.org/problems/ancestors-in-binary-tree/1
    }
    //class Solution
    //{

    //    public ArrayList<Integer> Ancestors(Node root, int target)
    //    {
    //        ArrayList<Integer> res = new ArrayList<>();
    //        ArrayList<Integer> temp = new ArrayList<>();
    //        recurse(root, temp, res, target);
    //        return res;


    //    }
    //    static void recurse(Node root, ArrayList<Integer> temp, ArrayList<Integer> res, int target)
    //    {
    //        if (root == null) return;
    //        if (root.data == target)
    //        {
    //            Collections.reverse(temp);
    //            res.addAll(temp);
    //            return;
    //        }
    //        temp.add(root.data);
    //        recurse(root.left, temp, res, target);

    //        recurse(root.right, temp, res, target);
    //        temp.remove(temp.size() - 1);

    //    }

    //}


}
