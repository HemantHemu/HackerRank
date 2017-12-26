//not completed, only two test cases passed

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ss = Console.ReadLine().Split();
            decimal n = Convert.ToDecimal(ss[0]);
            decimal k = Convert.ToDecimal(ss[1]);
            decimal maxInp = (decimal)Math.Pow((double)n, (double)(1/k));
            List<double> primeDict = new List<double> { };
            long[] primeGenerator = new long[(int)maxInp + 4];
            primeGenerator[2] = 1;
            for (int i = 2; i < maxInp + 2; i++)
            {
                if (primeGenerator[i] != -1)
                {
                    primeGenerator[i] = 1;
                    primeDict.Add(i);
                    for (int inc = 2, y = i * inc; y < maxInp + 2; inc++, y = i * inc)
                    {
                        primeGenerator[y] = -1;
                    }
                }
            }
            int total = 0;
            for (int i = 1; i < n + 1; i++) {
                bool all = true;
                foreach(var g in primeDict){
                    if (i % Math.Pow(g, (double)k) == 0) { all = !all; break; }
                }
                if (all) { ++total; }
            }
            Console.WriteLine(total);
        }
    }
}
