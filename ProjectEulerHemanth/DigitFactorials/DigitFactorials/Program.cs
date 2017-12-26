using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] factArray = new int[10];
            decimal outp = 0;
            factArray[0] = 1;
            for(int i =1;i<10;i++){
                factArray[i] = i * factArray[i - 1];
            }
            for (int i = 10; i < n; i++) {
                decimal factSum = 0;
                int temp = i;
                while(temp>0){
                    factSum += factArray[temp % 10];
                    temp = temp / 10;
                }
                if (factSum % i == 0) { outp += i; }
            }
            Console.WriteLine(outp);
            Console.ReadKey();
        }
    }
}
