// not completed


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class HighlyDivisibleTriangularNumber
    {
        public static void Bermuda()
        {
            int t = int.Parse(Console.ReadLine());
            int[] inp = new int[t];
            for(int i = 0; i < t; i++) {
                inp[i] = int.Parse(Console.ReadLine());
            }
            int[] copyOfInp = inp.ToArray();
            Array.Sort(copyOfInp);
            Int64[] outputUnorganised = new Int64[inp.Max()+2];
            Int64 triangularNumber = 0, triangularSeq = 1;

            for (int i = 0; i < t; i++)
            {
                while (true)
                { 
                triangularNumber = (triangularSeq * (triangularSeq + 1)) / 2;
                //count the divisors
                int div = triangularNumber % 2 == 0 ? 2 : 3, divCount = 2,divLimit = (int)Math.Ceiling( Math.Sqrt(triangularNumber));
                  while (div <= divLimit)
                  {
                      if (triangularNumber % div == 0) { divCount += 2; }
                        div += 1;
                    }
                    if (triangularNumber % divLimit == 0) { divCount -=1; }
                    if (divCount > copyOfInp[i]) { outputUnorganised[copyOfInp[i]] = triangularNumber; break; }
                    ++triangularSeq;
                }
            }
            Int64[] output = new Int64[t];
            for(int i =0;i<t;i++) {
                output[i] = outputUnorganised[inp[i]];
            }
            Console.Write(string.Join(Environment.NewLine, output));
            Console.ReadKey();
        }
    }
}
