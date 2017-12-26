// passed all test cases

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            int current = 0,valleys=0,previous=0;
            for (int i = 0; i < n; i++) {
                previous = current;
                if (ch[i] == 'U') { ++current; }
                else { --current; }
                if (previous == 0 && current == -1) { ++valleys; }
            }
            Console.WriteLine(valleys);
        }
    }
}
