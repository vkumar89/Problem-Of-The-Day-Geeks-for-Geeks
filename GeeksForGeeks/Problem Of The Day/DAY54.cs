using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY54
    {
        //Serialize and deserialize a binary tree
        //problem link=>>https://www.geeksforgeeks.org/problems/serialize-and-deserialize-a-binary-tree/1
    }
    //class Tree
    //{
    //    static int idx;
    //    public static void preOrder(Node rt, ArrayList<Integer> al)
    //    {
    //        if (rt == null)
    //        {
    //            al.add(-1);
    //            return;
    //        }
    //        al.add(rt.data);
    //        preOrder(rt.left, al);
    //        preOrder(rt.right, al);
    //    }
    //    public static Node create(ArrayList<Integer> al)
    //    {
    //        idx++;
    //        if (al.get(idx) == -1)
    //        {
    //            return null;
    //        }
    //        Node newNode = new Node(al.get(idx));
    //        newNode.left = create(al);
    //        newNode.right = create(al);
    //        return newNode;
    //    }
    //    // Function to serialize a tree and return a list containing nodes of tree.
    //    public ArrayList<Integer> serialize(Node root)
    //    {
    //        // code here
    //        ArrayList<Integer> a = new ArrayList<>();
    //        preOrder(root, a);
    //        return a;
    //    }

    //    // Function to deserialize a list and construct the tree.
    //    public Node deSerialize(ArrayList<Integer> A)
    //    {
    //        // code here
    //        idx = -1;
    //        Node root = create(A);
    //        return root;
    //    }
    //};


}
