using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPairs
{
    class Program
    {
        static int[] factDict = new int[10];
        static void FactGenerator(){
            factDict[0] = 1;
            for(int i = 1; i < 10; i++){
                factDict[i] = i * factDict[i - 1];
            }
        }
        static void Main(string[] args)
        {
            FactGenerator();
            int t = int.Parse(Console.ReadLine());
            while (t > 0){
                bool yeah = false;
                int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int[] inp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int len = inp.Length;
                for(int i =0;factDict[i]<len;i++){
                    if (inp[i] + inp[factDict[i]] == nk[1]) { yeah = true; break; }
                }
                Console.WriteLine(yeah?"TRUE":"FALSE");
                --t;
            }
            Console.ReadKey();
        }
    }
}
