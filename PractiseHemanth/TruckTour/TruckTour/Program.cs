using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Int64[] queries = new Int64[2*n];
            for(int i=0;i<2*n;i+=2)
            {
                string[] ss = Console.ReadLine().Split();
                queries[i] = Int64.Parse(ss[0]);
                queries[i+1] = Int64.Parse(ss[1]);
            }
            Int64 s = 0, rem = 0, cap = 0;
            bool flag = true;
            for (int i =0;i<2*n;i+=2)
            {
                flag = true;
                s = 0;
                rem = 0;
                cap = 0;
                if(queries[i]>= queries[i+1])
                {
                    s = i;
                    rem = n - i;
                    while (true)
                    {
                        cap += queries[s] - queries[s + 1];
                        if (cap < 0) { flag = false; break; }
                        s+=2;
                        if (s == 2*n) { s = 0; }
                        if (s == i) { break; }
                    }
                    if (flag) break;
                }
            }
            Console.WriteLine(s/2);
            Console.ReadKey();
        }
    }
}
