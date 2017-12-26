using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PrimeFear
    {
        public static void FearThePrime()
        {
            int t = int.Parse(Console.ReadLine());
            int[] Copyofinps = new int[t];
            int[] inps = new int[t];
            for(int i =0;i<t;i++)
            {
                inps[i] = int.Parse(Console.ReadLine());
                Copyofinps[i] = inps[i];
            }
            int maxInp = inps.Max();
            int[] primeGenerator = new int[maxInp+2];

            Array.Sort(inps);

            primeGenerator[0] = -1;
            primeGenerator[1] = -1;
            //mark all the primes upto the maxInp of given testcases
            for (int i = 2; i < maxInp + 2; i++) {
                if (primeGenerator[i] != -1) {
                    if (primeGenerator[i % 10] != -1) { primeGenerator[i] = 1; }
                    for (int inc = 2, y = i * inc; y < maxInp + 2; inc++, y = i * inc) {
                        primeGenerator[y] = -1;
                    }
                }
            }
            int prevCount = 0  //currentTestCaseCount = 0
                , looper=0,prevNumer =1;
            bool primeFlag = true;
            int[] output = new int[inps.Max()+1];

            for (int i = 0; i < t; i++) 
            {
                //currentTestCaseCount = 0;
                for (looper = prevNumer; looper <= inps[i]; looper++) {
                    if (primeGenerator[looper] == 1 && !looper.ToString().Contains('0'))  {  
                        primeFlag = true;
                    int temp = looper;

                    if (temp / 10 == 0) { prevCount++; }
                    else if (temp / 10 >= 1 && primeGenerator[temp % 10] == 1) {
                        do
                        {
                          temp = temp % (int)(Math.Pow(10, temp.ToString().Length - 1));
                          if (primeGenerator[temp] == -1) { primeFlag = false; break; }
                        }
                        while (temp / 10 > 0);
                            prevCount += primeFlag ? 1 : 0;
                    }
                }
                }
                prevNumer = looper;
                //prevCount += currentTestCaseCount;
                output[inps[i]] = prevCount;
                
            }
            int[] newOutput = new int[t];
            for(int inpTestCase = 0;inpTestCase<t;inpTestCase++){
                newOutput[inpTestCase] = output[Copyofinps[inpTestCase]];
            }
            Console.WriteLine(string.Join(Environment.NewLine, newOutput));
            Console.ReadKey();
        }
    }
}
