using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem_Of_The_Day
{
    internal class DAY60
    {
        //Root to Leaf Paths

        // problem link =>>https://www.geeksforgeeks.org/problems/root-to-leaf-paths/1
    }
    //class Solution
    //{
    //    public static ArrayList<ArrayList<Integer>> Paths(Node root)
    //    {
    //        // code here
    //        ArrayList<ArrayList<Integer>> ans = new ArrayList<>();
    //        List<Integer> path = new ArrayList<>();
    //        helper(root, path, ans);
    //        return ans;
    //    }

    //    public static void helper(Node root, List<Integer> path, ArrayList<ArrayList<Integer>> ans)
    //    {

    //        if (root == null) return;

    //        path.add(root.data);

    //        if (root.left == null && root.right == null)
    //        {

    //            ans.add(new ArrayList<>(path));
    //        }
    //        else
    //        {

    //            helper(root.left, path, ans);
    //            helper(root.right, path, ans);
    //        }

    //        path.remove(path.size() - 1);
    //    }
    //}
}
