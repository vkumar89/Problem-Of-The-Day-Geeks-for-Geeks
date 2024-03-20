using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY11
    {

    }
    //User function Template for C++

    /*
    structure of the node of the binary tree is as
    struct Node
    {
        int data;
        struct Node *left;
        struct Node *right;

        Node(int x)
        {
            data = x;
            left = NULL;
            right = NULL;
        }
    };
    */
    //class Solution
    //{
    //    int path = 0;
    //    int sum = 0;

    //    void solve(Node* root, int currLen, int currSum)
    //    {
    //        if (root == nullptr)
    //        {
    //            if (currLen > path)
    //            {
    //                path = currLen;
    //                sum = currSum;
    //            }
    //            else if (currLen == path)
    //            {
    //                sum = max(sum, currSum);
    //            }
    //            return;
    //        }

    //        solve(root->left, currLen + 1, currSum + root->data);
    //        solve(root->right, currLen + 1, currSum + root->data);
    //    }

    //    public:
    
    //int sumOfLongRootToLeafPath(Node* root)
    //    {
    //        solve(root, 0, 0);
    //        return sum;
    //    }
    //};
}
