//array cannot hold more than 10 power 9 indexes u fool... anyways its only 10 test cases, so do it normally

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestPrimeFactor
    {
        static List<Int64> primeDict = new List<Int64> { };
        public static void LPF()
        {

            int t = Convert.ToInt32(Console.ReadLine());
            Int64[] inp = new Int64[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                inp[a0] = Convert.ToInt64(Console.ReadLine());
            }

            int maxInp = (int)Math.Sqrt(inp.Max());
            int[] primeGenerator = new int[maxInp + 2];
            Int64[] output = new Int64[t];
            primeGenerator[0] = -1;
            primeGenerator[1] = -1;
            //mark all the primes upto the square root of maxInp of given testcases
            for (int i = 2; i < maxInp + 2; i++) {
                if (primeGenerator[i] != -1) {
                    primeGenerator[i] = 1;
                    primeDict.Add(i);
                    for (int inc = 2, y = i * inc; y < maxInp + 2; inc++, y = i * inc) {
                        primeGenerator[y] = -1;
                    }
                }
            }

            for(int i =0;i<t;i++){
                //check each number for prime individually
                int div = 1;
                while (true){
                    if (inp[i] % div == 0 && primeCheck(inp[i] / div)) { output[i] = inp[i] / div; break; }
                    ++i;
                }
            }
            Console.Write(string.Join(Environment.NewLine, output));
            Console.ReadKey();
        }

        public static bool primeCheck(long pd)
        {
            if (pd == 1 || pd == 0 || pd % 2 == 0) { return false; }
            if (pd == 2 || pd == 3 || pd == 5 || pd == 7 || pd == 11) { return true; }
            foreach (long primes in primeDict)
            {
                if (pd <= primes) { break; }
                else if (pd % primes == 0) { return false; }
            }
            return true;
        }

    }

}

