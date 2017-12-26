using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestChild
{
    class Solution
    { 
    static int commonChild(string s1, string s2)
    {
            
            // Complete this function
            int counter = 0;
            List<char> ss1 = s1.ToCharArray().ToList();
            List<char> ss2 = s2.ToCharArray().ToList();
            int len = ss1.Count();

            //regular array looping technique
            foreach (char ch in ss1)
            {
                if (!ss2.Contains(ch))
                {
                    ss1.RemoveAll(x => x == ch);
                }
            }
            foreach (char ch in ss2)
            {
                if (!ss1.Contains(ch))
                {
                    ss2.RemoveAll(x => x == ch);
                }
            }

            ////implement a while loop technique
            //while(true)
            //{

            //}
            counter++;
        return -1;
    }

    static void Main(String[] args)
    {
            
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            string s1 = "SHINCHAN";
            string s = s1;
            string s2 = "NOHARAAA";
            int result = commonChild(s1, s2);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
}
