using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarrysArraY
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2 * t; i++){
                int n = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split();
                int[] inp = Array.ConvertAll(s,int.Parse);
                for (int r = 0; r < n - 2; r++) {
                    int a = inp[r], b = inp[r + 1], c = inp[r + 2],count = 0;
                    while (!((a < b)&&(a < c))) {  }
                }
            }

        }
    }
}
