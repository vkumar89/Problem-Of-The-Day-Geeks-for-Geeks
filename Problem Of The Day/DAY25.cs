﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY25
    {

        //Kth common ancestor in BST

        //problem link=>>https://www.geeksforgeeks.org/problems/kth-common-ancestor-in-bst/1


    }
    //class Solution
    //{

    //    int LCA(Node root, int x, int y)
    //    {

    //        if (root == null)
    //        {
    //            return -1;
    //        }

    //        //We search for a mid value as
    //        //it will be always the first LCA of BST.
    //        if (x < root.data && y < root.data)
    //        {
    //            return LCA(root.left, x, y);
    //        }
    //        else if (x > root.data && y > root.data)
    //        {
    //            return LCA(root.right, x, y);
    //        }

    //        return root.data;

    //    }

    //    public int kthCommonAncestor(Node root, int k, int x, int y)
    //    {

    //        if (k == 0)
    //        {
    //            return 0;
    //        }

    //        int lca = LCA(root, x, y);

    //        ArrayList<Integer> arr = new ArrayList<>();
    //        Queue<Node> q = new ArrayDeque<>();
    //        q.add(root);

    //        while (!q.isEmpty())
    //        {

    //            Node curr = q.poll();
    //            arr.add(curr.data);
    //            if (curr.data == lca)
    //            {
    //                break;
    //            }

    //            if (curr.left != null)
    //            {
    //                q.add(curr.left);
    //            }
    //            else
    //            {
    //                q.add(new Node(-1));
    //            }
    //            if (curr.right != null)
    //            {
    //                q.add(curr.right);
    //            }
    //            else
    //            {
    //                q.add(new Node(-1));
    //            }

    //        }

    //        int p = arr.size() - 1;
    //        while (p != 0 && k > 1)
    //        {
    //            if (p % 2 == 0)
    //            {
    //                p = p / 2 - 1;
    //            }
    //            else
    //            {
    //                p = p / 2;
    //            }

    //            k--;

    //        }

    //        if (k > 1)
    //        {
    //            return -1;
    //        }

    //        return arr.get(p);

    //    }
    //}
}
