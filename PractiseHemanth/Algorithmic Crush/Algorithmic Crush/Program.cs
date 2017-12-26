using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmic_Crush
{
    class Solution
    {
        static void Main(string[] args)
        {
            string nm = Console.ReadLine();
            int size = int.Parse(nm.Split()[0]);
            int ops = int.Parse(nm.Split()[1]);
            string[] queries = new string[ops];
            for (int i=0;i<ops;i++)
            {
                queries[i] = Console.ReadLine();
            }
            Int64[] list = new Int64[size] ;
            for(int i=0;i<ops;i++)
            {
                string[] queryRow = queries[i].Split();
                int start = int.Parse(queryRow[0])-1;
                int end = int.Parse(queryRow[1]);
                int add = int.Parse(queryRow[2]);
                for (int j=start;j<end;j++)
                {
                    list[j] += add;
                }
            }
            Console.Write(list.Max());
            Console.ReadKey();
        }
    }
}
