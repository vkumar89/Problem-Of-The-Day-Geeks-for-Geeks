using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Problem_Of_The_Day
{
    internal class DAY62
    {
        //Combination Sum II

        //probelm link=>>https://www.geeksforgeeks.org/problems/combination-sum-ii-1664263832/1
    }
    //class Solution
    //{
    //    public List<List<Integer>> CombinationSum2(int arr[], int n, int k)
    //    {
    //        List<List<Integer>> result = new ArrayList<>();
    //        Arrays.sort(arr);
    //        subset(arr, n, k, new ArrayList<>(), result, 0, 0);
    //        return result;
    //    }

    //    private void subset(int arr[], int n, int k, List<Integer> current, List<List<Integer>> result, int sum, int index)
    //    {
    //        if (sum > k)
    //        {
    //            return;
    //        }

    //        if (sum == k)
    //        {
    //            result.add(new ArrayList<>(current));
    //            return;
    //        }

    //        for (int i = index; i < n; i++)
    //        {
    //            if (i > index && arr[i] == arr[i - 1])
    //            {
    //                continue; // Skip duplicates
    //            }

    //            current.add(arr[i]);
    //            subset(arr, n, k, current, result, sum + arr[i], i + 1);
    //            current.remove(current.size() - 1);
    //        }
    //    }
    //}
}
