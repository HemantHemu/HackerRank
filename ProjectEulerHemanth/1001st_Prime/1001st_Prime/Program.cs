//success, 100/100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001st_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<long> inp = new List<long> { };
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                inp.Add(n);
            }
            long[] primeGenerator = new long[1000000];
            primeGenerator[2] = 1;
            List<long> primeDict = new List<long> { };
            for (int i = 2; i < 1000000 ; i++)
            {
                if (primeGenerator[i] != -1)
                {
                    primeGenerator[i] = 1;
                    primeDict.Add(i);
                    for (int inc = 2, y = i * inc; y < 1000000 ; inc++, y = i * inc)
                    {
                        primeGenerator[y] = -1;
                    }
                }
            }
            foreach (int y in inp) {
                Console.WriteLine(primeDict[y-1]);
            }
            Console.ReadKey();
        }
    }
}
