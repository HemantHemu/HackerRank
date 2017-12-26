using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Digit_Fibanocci_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int t = int.Parse(Console.ReadLine());
            int[] inp = new int[t];
            
            for (int i = 0; i < t; i++) {
                inp[i] = int.Parse(Console.ReadLine());
            }
            int maxInp = inp.Max();
            int[] digitCountFib = new int[maxInp + 2];
            decimal fibsummer = 0, f1 = 1, f2 = 1 ;
            int  fibCount = 2;
            int modChecker = 1;
            int power = 1;
            while (modChecker <= maxInp) {
                decimal powChecker = (decimal)(Math.Pow(10, power));
                fibsummer = f1 + f2;
                fibCount++;
                if(fibsummer/powChecker >= 1) {
                    ++modChecker;
                    ++power;
                    digitCountFib[modChecker] = fibCount;
                }
                if(modChecker == maxInp) { break; }
                f1 = f2;
                f2 = fibsummer;

            }
            for(int i =0;i<t;i++)
            {
                Console.WriteLine(digitCountFib[inp[i]]);
            }
            Console.WriteLine("asjkdhasjkdfh");
        }
    }
}
