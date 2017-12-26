using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPDFvieWer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();
            char[] ch = word.Distinct().ToArray();
            int max = 0;
            foreach (int c in ch) {
                if (h[c - 97] > max) { max = h[c - 97]; }
            }
            Console.WriteLine(word.Length*max);
        }
    }
}
