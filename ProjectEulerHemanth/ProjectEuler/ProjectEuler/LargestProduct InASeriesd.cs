using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestProduct_InASeriesd
    {
        public static void TheBigShort()
        {
            int t = int.Parse(Console.ReadLine());
            Int64[] output = new Int64[t];
            for (int i = 0; i < t; i++)
            {
                int[] nk = Array.ConvertAll(Console.ReadLine().Trim().Split(' ').ToArray(), Convert.ToInt32);
                string number = Console.ReadLine().Trim();
                int[] inp = new int[nk[0]];

                for (int reader = 0; reader < nk[0]; reader++)
                { inp[reader] = int.Parse(number.Substring(reader, 1)); }

                Int64 max = 0, product = 1;
                for (int first = 0; first < nk[1]; first++)
                {
                    product *= inp[first];
                }
                max = product > max ? product : max;

                for (int looper = nk[1]; looper < nk[0]; looper++)
                {
                    if (inp[looper - nk[1]] != 0) { product = product / inp[looper - nk[1]]; product *= inp[looper]; }
                    else
                    { //calculate the product again
                        product = 1;
                        for (int first = 0; first < nk[1]; first++)
                        {
                            product *= inp[first + looper - nk[1] + 1];
                        }
                    }
                    max = product > max ? product : max;
                }
                output[i] = max;
            }
            Console.Write(string.Join(Environment.NewLine, output));
        }
    }

}
