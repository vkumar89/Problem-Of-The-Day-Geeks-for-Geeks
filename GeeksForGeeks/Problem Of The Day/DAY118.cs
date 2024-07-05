using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY118
    {
        //Vertical Width of a Binary Tree
        //problem link =>>https://www.geeksforgeeks.org/problems/vertical-width-of-a-binary-tree/1
    }
    //class Solution
    //{

    //    static class Pair
    //    {
    //        int hd;
    //        Node root;

    //        public Pair(int hd, Node root)
    //        {
    //            this.hd = hd;
    //            this.root = root;
    //        }
    //    }

    //    public int verticalWidth(Node root)
    //    {

    //        if (root == null) return 0;

    //        Queue<Pair> q = new LinkedList<>();
    //        q.add(new Pair(0, root));

    //        Set<Integer> set = new HashSet<>();

    //        while (!q.isEmpty())
    //        {
    //            Pair temp = q.poll();
    //            if (temp.hd < 0)
    //            {
    //                set.add(Integer.MAX_VALUE + temp.hd);
    //            }
    //            else
    //            {
    //                set.add(temp.hd);
    //            }

    //            if (temp.root.left != null) q.add(new Pair(temp.hd - 1, temp.root.left));
    //            if (temp.root.right != null) q.add(new Pair(temp.hd + 1, temp.root.right));
    //        }

    //        return set.size();
    //    }
    //}



}
