using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<int> inp = new List<int> { };
            List<int> output = new List<int> { };
            while (t > 0)
            {
                inp.Add(int.Parse(Console.ReadLine()));
                t--;
            }
            foreach (int ii in inp)
            {
                int outp = 0;
                for (int i = 2; i < ii; i++) { 
                int rec = sumOfDivisors(i);
                if (rec!=i && !output.Contains(i) && i == sumOfDivisors(rec)){
                        output.Add(rec);
                        output.Add(i);
                    outp += rec;
                    outp += i;
                }
              }
                foreach(int y in output)
                {
                    Console.WriteLine(y); 
                }
                Console.WriteLine("===================");
                Console.WriteLine(outp);
            }
            Console.ReadKey();
        }
       
        public static int sumOfDivisors(int i)
        {
            int sum = 1,limit = i / 2;
            for(int dd = 2;dd<=limit;dd++)
            {
                if(i%dd==0)
                {
                    sum += dd;
                }
            }
            return sum;
        }

   } 
}
