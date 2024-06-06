using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY57
    {
        //Vertical sum
        //problem link =>> https://www.geeksforgeeks.org/problems/vertical-sum/1
    }
    //class Solution
    //{
    //    public ArrayList<Integer> verticalSum(Node root)
    //    {
    //        // add your code here
    //        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
    //        help(root, 0, map);
    //        ArrayList<Integer> ans = new ArrayList<Integer>();
    //        ArrayList<Integer> a = new ArrayList<Integer>(map.keySet());
    //        Collections.sort(a);
    //        for (Integer p:a)
    //        {
    //            ans.add(map.get(p));
    //        }
    //        // System.out.println(map);
    //        return ans;
    //    }
    //    void help(Node root, int l, HashMap<Integer, Integer> map)
    //    {
    //        if (root == null)
    //        {
    //            return;
    //        }
    //        if (map.containsKey(l))
    //        {
    //            map.put(l, map.get(l) + root.data);
    //        }
    //        else
    //        {
    //            map.put(l, root.data);
    //        }
    //        help(root.left, l - 1, map);
    //        help(root.right, l + 1, map);
    //    }
    //}


}
