using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ArrangingDominos
    {
        public static void Gladiator()
        {
            int t = int.Parse(Console.ReadLine());
            Int64[] output = new Int64[t];
            for(int i =0;i<t;i++)
            {
                Int64 n = Int64.Parse(Console.ReadLine());
                Int64 area = 5 * n;
                Int64 possible_ways = 1, tempArea = 0;
                float t52 = 1, t51 = 0;
                while(tempArea <= area)
                {
                    t51 = (long)Math.Floor((double)((area - t52 * 10) / 5));
                    tempArea = (Int64)(t51 * 5 + t52 * 10);
                    if (tempArea == area) {
                        if (t51 == 0) { possible_ways++; break; }
                            possible_ways += conditionalFactorial(t52 + t51, t52 > t51 ? t52 : t51, t52 < t51 ? t52 : t51); }
                    t52++;
                }
                output[i] = possible_ways % 1000000007;
            }
            Console.Write(string.Join(Environment.NewLine,output));
            Console.ReadKey();
        }
        public static Int64 conditionalFactorial(float num1, float num2,float num3)
        {
            float fact = 1;
            while(num1>num2)
            {
                fact *= num1/num3;
                --num1;
                if (num3 > 1) { --num3; }
            }
            return (Int64)fact % 1000000007;
        }
        
    }
}
