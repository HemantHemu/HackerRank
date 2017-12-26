// 2 test cases Run Time Error
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<decimal> inp = new List<decimal> { };
            for (int a0 = 0; a0 < t; a0++)
            {
                decimal n = Convert.ToDecimal(Console.ReadLine());
                inp.Add(n);
            }
            decimal maxInp = inp.Max();
            List<decimal> primeDict = new List<decimal> { };

            int[] primeGenerator = new int[Convert.ToInt64(maxInp) + 2];

            // generate primes till max
            //primeGenerator[2] = 1;
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


            foreach (decimal lg in inp)
            {
                if (primeDict.Contains(lg)) { Console.WriteLine(lg); continue; }
                int div = primeDict.IndexOf(primeDict.Last(x => x < lg / 2 + 1));

                while (div >= 0)
                {
                    if (lg % primeDict[div] == 0)
                    {
                        Console.WriteLine(primeDict[div]);
                        break;
                    }
                    div--;
                }

            }
            //Console.ReadKey();
            Console.ReadKey();

        }
    }
}


//for (long l = maxInp%2==0?maxInp-1:maxInp ; l>10 ; l -= 2)
//{
//    if (primeCheck(l))
//    {
//        primeDict.Add(l);
//    }
//}
//primeDict.Add(7);
//primeDict.Add(5);
//primeDict.Add(3);
//primeDict.Add(2);
//foreach(int h in isPrime)
//{
//    Console.WriteLine(h); 
//}
//foreach (long primer in primeDict)
//                {
//                    if(lg % primer == 0)
//                    {
//                        Console.WriteLine(primer);
//                        break;
//                    }
//                }