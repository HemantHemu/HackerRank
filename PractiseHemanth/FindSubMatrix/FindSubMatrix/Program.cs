using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_R = Console.ReadLine().Split(' ');
            int R = Convert.ToInt32(tokens_R[0]);
            int C = Convert.ToInt32(tokens_R[1]);
            string[] G = new string[R];
            for (int G_i = 0; G_i < R; G_i++)
            {
                G[G_i] = Console.ReadLine();
            }
            string[] tokens_r = Console.ReadLine().Split(' ');
            int r = Convert.ToInt32(tokens_r[0]);
            int c = Convert.ToInt32(tokens_r[1]);
            string[] P = new string[r];
            for (int P_i = 0; P_i < r; P_i++)
            {
                P[P_i] = Console.ReadLine();
            }

            int hitR = 0, hitC = 0;
            bool hitFound = false, matchFound = false;

            for (int j = 0; j < R-r+1; j++)
            {
                for (int i = 0; i < C - r + 1; i++)
                {
                    if (G[j].ElementAt(i) == P[0].ElementAt(0))
                    { hitR = j; hitC = i; hitFound = true; break; }
                }
                if ((hitFound)&& (G[hitR].Substring(hitC, c) == P[0]))
                {
                    matchFound = true;
                        for (int i = hitR, sr = 0; sr < r && i < (hitR + r); i++, sr++)
                        {
                            for (int jj = hitC, sc = 0; sc < c && jj < (hitC + c); jj++, sc++)
                            {
                                if (G[i].ElementAt(jj) != P[sr].ElementAt(sc))
                                {
                                    matchFound = false;
                                    break;
                                }
                            }
                            if (!matchFound) {  hitFound = false; break; }
                        }         
                }
                if (matchFound) { break; }
            }
            Console.WriteLine(matchFound?"YES":"NO");

            Console.ReadKey();
        }
    }
}
