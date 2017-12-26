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
            int n = Convert.ToInt32(Console.ReadLine());
            Int64[][] M = new Int64[n][];

            bool possible = true;
            List<Int64> rsum = new List<Int64> { };
            List<Int64> csum = new List<Int64> { };
            for (int M_i = 0; M_i < n; M_i++)
            {
                string[] M_temp = Console.ReadLine().Split(' ');
                M[M_i] = Array.ConvertAll(M_temp, Int64.Parse);
            }
            // your code goes here
            for (int i = 0; i < n; i++)
            {
                int column = i;
                Int64 rowsum = 0, columnsum = 0;
                for (int j = 0; j < n; j++)
                {
                    rowsum += M[i][j];
                }
                rsum.Add(rowsum);
                for(int j=0;j<n;j++)
                {
                    columnsum += M[j][column];
                }
                csum.Add(columnsum);
                Int64[] rsumarr = rsum.ToArray();
                Array.Sort(rsumarr);
                Int64[] csumarr = csum.ToArray();
                Array.Sort(csumarr);
                for (int f =0; f<n;f++)
                {
                    if (rsumarr[f] != csumarr[f])
                    {
                        possible = false;
                        Console.WriteLine("Impossible");
                        break;
                    }
                }
                
            }
            if (possible) { Console.WriteLine("Possible"); }
        }
        Console.ReadKey();
    }
}
