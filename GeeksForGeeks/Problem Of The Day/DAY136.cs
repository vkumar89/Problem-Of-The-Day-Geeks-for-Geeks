﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY136
    {
        //Merge two BST 's
        //problem link=>>https://www.geeksforgeeks.org/problems/merge-two-bst-s/1
    }
    //class Solution
    //{
    //    private void DfsPannuBro(Node root, List<Integer> list)
    //    {
    //        if (root == null)
    //        {
    //            return;
    //        }
    //        DfsPannuBro(root.left, list);
    //        list.add(root.data);
    //        DfsPannuBro(root.right, list);
    //    }

    //    private List<Integer> mergePannuBro(List<Integer> list1, List<Integer> list2)
    //    {
    //        List<Integer> res = new ArrayList<>();

    //        int n = list1.size(), m = list2.size();
    //        int i = 0, j = 0;

    //        while (i < n && j < m)
    //        {
    //            int a = list1.get(i), b = list2.get(j);
    //            if (a < b)
    //            {
    //                res.add(a);
    //                i++;
    //            }
    //            else
    //            {
    //                res.add(b);
    //                j++;
    //            }
    //        }

    //        while (i < n)
    //        {
    //            res.add(list1.get(i++));
    //        }

    //        while (j < m)
    //        {
    //            res.add(list2.get(j++));
    //        }

    //        return res;
    //    }

    //    public List<Integer> merge(Node root1, Node root2)
    //    {

    //        List<Integer> list1 = new ArrayList<>();
    //        List<Integer> list2 = new ArrayList<>();

    //        DfsPannuBro(root1, list1);
    //        DfsPannuBro(root2, list2);

    //        return mergePannuBro(list1, list2);
    //    }
    //}
}
