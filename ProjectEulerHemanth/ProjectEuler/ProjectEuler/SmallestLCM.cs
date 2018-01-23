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
            for (int a0 = 0; a0 < t; a0++)
            {
                inp[a0] = Convert.ToInt32(Console.ReadLine());
            }

            int[] primeGenerator = new int[45];
            primeGenerator[0] = -1;
            primeGenerator[1] = -1;

            for (int i = 2; i < 45; i++)
            {
                if (primeGenerator[i] != -1)
                {
                    primeGenerator[i] = 1;
                    for (int inc = 2, y = i * inc; y < 45; inc++, y = i * inc)
                    {
                        primeGenerator[y] = -1;
                    }
                }
            }
            int[] output = new int[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                int i = 0,lcm = 1;
                while (i<=inp[a0]){
                    if (primeGenerator[i] == 1){
                        lcm *= (int)Math.Pow(i, Math.Floor(Math.Log(inp[a0], i)));
                    }
                    i++;
                }
                output[a0] = lcm;
            }
            Console.Write(string.Join(Environment.NewLine,output));
            Console.ReadKey();
        }
        

    }
}
