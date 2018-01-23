using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LongestCollatzSequence
    {
        public static void IndianSequence()
        {
            int t = int.Parse(Console.ReadLine());
            int[] inp = new int[t];
            for(int i =0;i<t;i++)
            {
                inp[i] = int.Parse(Console.ReadLine());
            }
            Int64 max = inp.Max() + 1, tempmax = -1, maxNumber = 0, inpCounter = 0;
            int[] copyOfInp = inp.ToArray();
            Array.Sort(copyOfInp);
            int[] collatzDict = new int[max];

            int[] outputUnorganised = new int[max];
            int[] output = new int[t];

            //pre compute all the collatzes

            for(int i =1;i<max;i++)
            {
                Int64 n = i, collatzCount = 0;
                while (true)
                {
                    if (n < max && collatzDict[n] != 0)  { collatzCount += collatzDict[n]; break; }
                    else if (n % 2 == 0) { n = n / 2; }
                    else { n = 3 * n + 1; }
                    ++collatzCount;
                    if (n < 0)
                    {
                        Console.WriteLine("what the fun");
                    }
                    if(n == 1) { break; }
                }
                collatzDict[i] = (int)collatzCount;
                if(collatzDict[i] >= tempmax) { tempmax = collatzDict[i];maxNumber = i; }
                if (inpCounter < t && i == copyOfInp[inpCounter])  { outputUnorganised[copyOfInp[inpCounter]] = (int)maxNumber; ++inpCounter; }
            }

            for(int i =0;i<t;i++)
            {
                output[i] = outputUnorganised[inp[i]];
            }

            Console.Write(string.Join(Environment.NewLine, output));
            Console.ReadKey();
        }
    }
}
