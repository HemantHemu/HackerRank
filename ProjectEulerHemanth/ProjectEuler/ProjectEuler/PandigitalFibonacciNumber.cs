using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PandigitalFibonacciNumber
    {
        public static void pfn()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int fibCounter = 2,fib=0;
            while (true){
                fib = a + b;
                if (fib > 2000000) { Console.WriteLine("no solution"); break; }
                ++fibCounter;
                if (fib.ToString().Length>=k && PandigitalFib(fib,k)) { Console.WriteLine(fibCounter); break; }
                a = b;
                b = fib;
            }
            Console.ReadKey();
        }
        public static bool PandigitalFib(int fib,int k)
        {
            string fibString = fib.ToString();
            string fibStringCheck = fibString.Substring(0,k);
            string fibStringReverseCheck = fibString.Substring(fibString.Length-k, k);
            for (int i = 1; i<k + 1; i++){
                string tmp = i.ToString();
                if (!(fibStringCheck.Contains(tmp) && fibStringReverseCheck.Contains(tmp))) { return false; }
            }
            return true;
        }
    }
}
