using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SummationOfPrimes
    {
        public static void SeventhMandarin()
        {
            int t = int.Parse(Console.ReadLine());
            int[] inp = new int[t];
            for(int i = 0; i < t; i++){
                inp[i] = int.Parse(Console.ReadLine());
            }

            int maxInp = inp.Max();
            int[] primeGenerator = new int[maxInp + 2];
            List<int> primeDict = new List<int> { };

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
            
            Int64[] output = new Int64[t];

            Int64 adder = 0;

            for (int i = 0; i < t; i++) {
                adder = 0;
               foreach(int prime in primeDict)
                {
                    if (prime > inp[i]) { break; }
                    adder += prime;
                }
                output[i] = adder;
            }

            Console.Write(string.Join(Environment.NewLine, output));

        }
    }
}
