using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDigitSum_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<UInt64> input = new List<UInt64> { };
            while(t>0)
            {
                input.Add(Convert.ToUInt64(Console.ReadLine()));
                t--;
            }
            List<UInt64> sortedInput = new List<UInt64> { };
            sortedInput = input;
            sortedInput.Sort();
            UInt64[] factorialDictionary = new UInt64[sortedInput.Last()+1];
            foreach(UInt64 y in sortedInput)
            {
                UInt64 fact = 1,yy=y;
                if (yy == 0 || yy == 1) { factorialDictionary[y] = 1; continue; }
                while (yy > 1)
                {
                    if (factorialDictionary[yy] != 0) { fact = fact * factorialDictionary[yy]; break; }
                    fact = fact * yy;
                    yy--;
                }
                factorialDictionary[y] = fact;
            }
            foreach(UInt64 z in input)
            {
                Console.WriteLine(digitSum(factorialDictionary[z]));
            }
            Console.ReadKey();
        }

        private static UInt64 digitSum(UInt64 yy)
        {
            UInt64 dsum = 0;
            while (yy > 0)
            {
                dsum += yy % 10;
                yy = yy / 10;
            }
            return dsum;
        }

    }
}
