using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SmallestMultiple
    {
        public static void FightClub()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] inp = new int[t];
            for (int a0 = 0; a0 < t; a0++) {
                inp[a0] = Convert.ToInt32(Console.ReadLine());
            }

            int[] primeGenerator = new int[44];

            for (int i = 2; i < 44 + 2; i++)
            {
                if (primeGenerator[i] != -1)
                {
                    primeGenerator[i] = 1;
                    primeDict.Add(i);
                    for (int inc = 2, y = i * inc; y < maxInp + 2; inc++, y = i * inc)
                    {
                        primeGenerator[y] = -1;
                    }
                }
            }

            for (int a0 = 0; a0 < t; a0++) {

            }
        }

       
    }
}
