//big int is not available in c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> tempInp = new List<int> { };
            while(t>0)
            {
                tempInp.Add(int.Parse(Console.ReadLine()));
                t--;
            }
            int max = tempInp.Max();
            UInt64[] dict = new UInt64[max + 2];
            dict[0] = 1;
            for(int i = 1; i < max + 2; i++) {
                dict[i] = dict[i - 1] * 2;
            }
            foreach(int y in tempInp)
            {
                UInt64 sum = 0;
                UInt64 dd = dict[y];
                while (dd > 0) {
                    sum += dd % 10;
                    dd = dd / 10;
                }
                Console.WriteLine(sum);

            }
            Console.ReadKey();
        }
    }
}
