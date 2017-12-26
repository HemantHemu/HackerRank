using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < Q; a0++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int countOfSteps = 0;
                if (N == 0) { Console.WriteLine(countOfSteps); continue; }
                while (true)
                {
                    if (N == 1) { countOfSteps++; break; }
                    if ((N % 2 == 1 && isPrime(N))||(N==2)) { N -= 1; }
                    else
                    {
                        int ff = findFactor(N);
                        N = ((ff >= N / ff)) ? ff : N / ff;
                    }
                    countOfSteps++;
                }
                Console.WriteLine(countOfSteps);
            }
            Console.ReadKey();
        }
        public static int findFactor(int n)
        {
            int sqrt = (int)Math.Sqrt((Double)n);
            int s = 0;
            if (n % 2 == 0) {  s = sqrt % 2 == 0 ? sqrt : sqrt - 1; }
            else {  s = sqrt % 2 == 0 ? sqrt -1: sqrt ; }
            while (s>0)
            {
                if (n % s == 0)
                {
                    return s;
                }
                s = s - 1;
            }
            return 2;
        }
        public static bool isPrime(int n)
        {
            int l = (int)Math.Sqrt((Double)n);
            if (n ==2 || n==3)
            { return true; }
            for(int i = 3; i <= l+1 ; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
        }
    }
}
