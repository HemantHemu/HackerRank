// idiot , stupid logic, after sorting the array,  inp[i] == length-i; then true; will do

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class NobleArray
    {
        public static void RabindranathTagore()
        {
            int t = int.Parse(Console.ReadLine());
            List<int> inp = new List<int> { };
            inp = Array.ConvertAll(Console.ReadLine().Trim().Split(' ').ToArray(),Convert.ToInt32).ToList();
            int answer = solve(inp);
            Console.WriteLine(answer);
        }
        public static int solve(List<int> A)
        {
            int[] countArray = new int[A.Max() + 1];
            foreach(int num in A) {
                int inc = 1;
                while(inc<num) {
                    countArray[inc]++;
                    ++inc;
                }
            }
            foreach(int num in A)
            {
                if (countArray[num] == num) { return 1; }
            }

            return -1;
        }
    }
}
