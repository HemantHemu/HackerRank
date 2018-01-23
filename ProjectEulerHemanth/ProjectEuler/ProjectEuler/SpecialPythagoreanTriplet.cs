using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SpecialPythagoreanTriplet
    {
        public static void JaiLavaKusa()
        {
            int t = int.Parse(Console.ReadLine());
            int[] output = new int[t];
            for (int i = 0; i < t; i++) {
                int n = int.Parse(Console.ReadLine());
                int a, b, c, max = -1,product =1;
                for(a=1;a<n/3;a++){
                    b = (n * n - 2 * a * n) / (2 * n - 2 * a);
                    c = n - a - b;
                    if(c*c == a*a + b * b) {
                        product = a * b * c;
                        max = product > max ? product : max;
                    }
                }
                output[i] = max;
            }
            Console.Write(string.Join(Environment.NewLine,output));
            Console.ReadKey();
        }
    }
}
