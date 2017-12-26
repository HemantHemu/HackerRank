//last two test cases failing//
//data type incompatible
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerfulDigitCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double checker = Math.Pow(10, (double)n);
            double Q = 0,temp=0;
            for (int i = 1; i < checker; i++) {
                temp = Math.Pow(i, n);
                if (temp / (checker / 10) >= 1 && temp / (checker / 10) < 10) { Console.WriteLine(temp); }
                if(temp / (checker / 10) > 10) { break; }
            }
            Console.WriteLine("asdasdasd");
        }
    }
}
