using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Of_The_Day
{
    internal class Day1
    {
        static void Main()
        {
            //Remove all duplicates from a given string

            int testcases;
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)
            {
                string str = Console.ReadLine().Trim();
                Day1 obj = new Day1();
                string res = obj.removeDuplicates(str);
                Console.WriteLine(res + "\n");
            }
            
        }
        public string removeDuplicates(string str)
        {
            string temp = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (temp.Contains(str[i]) == false)
                {
                    temp = temp + str[i];
                }
            }
            return temp;
        }
    }
}
