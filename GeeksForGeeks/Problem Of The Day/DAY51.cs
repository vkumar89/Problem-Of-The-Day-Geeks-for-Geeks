using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class DAY51
    {
        // Remove every kth node
        //problem link=>>https://www.geeksforgeeks.org/problems/remove-every-kth-node/1
    }
    //class Solution
    //{
    //    public:
    //  Node* deleteK(Node* head, int K)
    //    {
    //        //Your code here
    //        if (K == 1) return nullptr;
    //        Node* prev = nullptr;
    //        Node* temp = head;
    //        int count = 0;
    //        while (temp != nullptr)
    //        {
    //            count++;
    //            if (count == K)
    //            {
    //                prev->next = temp->next;
    //                delete(temp);
    //                if (prev->next != nullptr)
    //                    temp = prev->next;
    //                count = 0;
    //                continue;
    //            }

    //            prev = temp;
    //            temp = temp->next;
    //        }
    //        return head;
    //    }
    //};

}
