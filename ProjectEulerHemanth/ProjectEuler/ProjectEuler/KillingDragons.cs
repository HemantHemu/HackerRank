using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class KillingDragons
    {
        public static void killingVeerappan()
        {
            int t = int.Parse(Console.ReadLine());
            int[] output = new int[t];
            for(int i = 0; i < t; i++) {
                int n = int.Parse(Console.ReadLine());
                int[] dragonStrength = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), Convert.ToInt32);
                int[] redBull = Array.ConvertAll(Console.ReadLine().Split(' ').ToArray(), Convert.ToInt32);
                bool runSucceeded = true;
                //start running
                for (int index = 0; index < n; index++) {
                    int blood;
                    runSucceeded = true;
                    //Proceed only if headstart is good
                    if (redBull[index] >= dragonStrength[index]){
                        blood = redBull[index] - dragonStrength[index];

                        //from now check the blood and proceed upto the end of the LOOP
                        for (int tempLooper = index + 1; tempLooper < index + n; tempLooper++) {
                            blood += redBull[tempLooper > n - 1 ? tempLooper - n : tempLooper] - dragonStrength[tempLooper > n - 1 ? tempLooper - n : tempLooper];
                            if (blood<0) { runSucceeded = false; break; }
                        }
                    }
                    else { runSucceeded = false; }
                    if (runSucceeded) { output[i] = index + 1; break; }
                }
                if (!runSucceeded) { output[i] = -1; }
            }
            Console.Write(String.Join(Environment.NewLine, output));
            Console.ReadKey();
        }
    }
}
