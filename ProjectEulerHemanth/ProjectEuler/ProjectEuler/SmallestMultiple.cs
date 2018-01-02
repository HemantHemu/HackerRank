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
            for (int a0 = 0; a0 < t; a0++) {

            }
        }

        public static int LCMGenerationofTwoNumbers(int n1, int n2)
        {
            if(n1%n2 == 0) { return LCMGenerationofTwoNumbers(n1, n2 - 1); }
            else { return LCMofTwoNumbers(n1, n2 - 1); }
            return 2;
        }
    }
}
