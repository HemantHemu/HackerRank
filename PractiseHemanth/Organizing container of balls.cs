using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            bool possible = true;
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] M = new int[n][];
            for (int M_i = 0; M_i < n; M_i++)
            {
                string[] M_temp = Console.ReadLine().Split(' ');
                M[M_i] = Array.ConvertAll(M_temp, Int32.Parse);
            }
            // your code goes here
            for(int i =0;i<n;i++)
            {
                int rowsum = M[i].Sum,columnsum=0;
                for (int j = 0; j < n; j++)
                {
                    columnsum += M[i][j];
                }
                if(rowsum!=columnsum){
                    possible = false;
                    Console.WriteLine("Impossible");
                    break;
                }
            }
            if (possible) { Console.WriteLine("Possible"); }
        }
        Console.ReadKey();
    }
}
