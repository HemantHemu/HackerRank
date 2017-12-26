//solved,,,100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruncatablePrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), z = 0, primeSum = 0 ;
            //generate primes
            int[] primeGenerator = new int[n + 2];
            int[] primeDict = new int[n/2];
            primeGenerator[2] = 1;
            for (int i = 2; i < n + 2; i++)
            {
                if (primeGenerator[i] != -1)
                {
                    primeGenerator[i] = 1;
                    primeDict[z] = i; ++z;
                    for (int inc = 2, y = i * inc; y < n + 2; inc++, y = i * inc)
                    {
                        primeGenerator[y] = -1;
                    }
                }
            }
            int power = 2,powCheck = (int)Math.Pow(10,power);
            for (int i = 8; i < z + 1; i++) {
                if (primeDict[i] > powCheck) { ++power; powCheck = (int)Math.Pow(10, power); }
                int temp = primeDict[i],tempPower = powCheck/10;
                bool all = true;
                //checking from right to left
                while (tempPower >= 10) {
                    if (primeGenerator[temp % tempPower] != 1) { all = false;break; }
                    tempPower = tempPower / 10;
                }
                //checking from left to right
                if (all)
                {
                    temp = primeDict[i];
                    tempPower = powCheck/10;
                    while (tempPower >= 10)
                    {
                        if (primeGenerator[temp / tempPower] != 1) { all = false; break; }
                        tempPower = tempPower / 10;
                    }
                }
                if (all) { primeSum += primeDict[i]; }
            }
            Console.WriteLine(primeSum);
            Console.ReadKey();
        }
    }
}
