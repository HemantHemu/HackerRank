//only one test case solved

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutivePositiveDivisors
{
    class Program
    {
        //still did not work, 
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            decimal[] inp = new decimal[t];
            decimal[] copyOfInp = new decimal[t];
            for (int i = 0; i < t; i++) {
                inp[i] = Convert.ToDecimal(Console.ReadLine());
                copyOfInp[i] = inp[i];
            }
            decimal maxInp = inp.Max();

            Array.Sort(inp);

            int[] divDict = new int[Convert.ToInt64(maxInp) + 2];
            int[] outDict = new int[Convert.ToInt64(maxInp) + 2];
            divDict[1] = -1;
            //generate divisor counts except self and 1

            for (decimal i = 2,z=0,counter=0,sortI=0; i < maxInp + 2; i++)
            {

                    for (decimal inc = 2, y = i * inc; y < maxInp + 2; inc++, y = i * inc)
                    {
                        divDict[Convert.ToInt64(y)] += 1;
                    }
                if (i >= 3) {
                    if (divDict[Convert.ToInt64(i)] == divDict[Convert.ToInt64(i - 1)]) {
                        outDict[Convert.ToInt64(i-1)] = 1;
                    }
                }
            }
            int[] output = new int[t];
            int[] tempOutput = new int[(int)maxInp+1];
            int sum = 0, c = 0;
            for (int i = 0; i < t; i++) {
                
                while (c < inp[i]) { sum += outDict[c];++c; }
                tempOutput[(int)inp[i]] = sum;
            }
            for(int i = 0; i < t; i++){
                output[i] = tempOutput[(int)inp[i]];
            }
            Console.WriteLine(string.Join(Environment.NewLine, output));
            Console.ReadKey();
        }
    }
}


/*
 TimeOUT COde, but the first code
             int t = int.Parse(Console.ReadLine());
            int[] inp = new int[t];
            for (int i = 0; i < t; i++) {
                inp[i] = int.Parse(Console.ReadLine());
            }
            int maxInp = inp.Max();
            int[] sortedInput = new int[t];
            sortedInput = inp;
            Array.Sort(sortedInput);
            int[] divDict = new int[maxInp + 2];
            int[] outDict = new int[maxInp + 2];
            divDict[1] = -1;
            //generate divisor counts except self and 1

            for (int i = 2,z=0,counter=0,sortI=0; i < maxInp + 2; i++)
            {

                    for (int inc = 2, y = i * inc; y < maxInp + 2; inc++, y = i * inc)
                    {
                        divDict[y] += 1;
                    }
                if (i >= 3) {
                    if (divDict[i] == divDict[i - 1]) {
                        counter += 1;
                    }
                    if (sortI<t && i == sortedInput[sortI]) {
                        outDict[i] = counter;
                        ++sortI;
                    }
                }
            }
            for (int i = 0; i < t; i++) {
                Console.WriteLine(outDict[inp[i]]);
            }
            

      */
