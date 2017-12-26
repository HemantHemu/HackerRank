using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap__QHeap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Int64 n1, min = 99999999999, n2;
            List<Int64> abc = new List<Int64> { };
            while (n > 0)
            {
                string[] inps = Console.ReadLine().Split();
                n1 = Int64.Parse(inps[0]);
                switch (n1)
                {

                    case 1:
                        n2 = Int64.Parse(inps[1]);
                        min = (min > n2) ? n2 : min;
                        abc.Add(n2);
                        break;
                    case 2:
                        n2 = Int64.Parse(inps[1]);
                        abc.Remove(n2);
                        if (min == n2)
                        {
                            if (abc.Count == 0) { min = 999999; }
                            else { min = abc.Min(); }
                        }
                        break;
                    case 3:
                        Console.WriteLine(min);
                        break;
                }

                n--;
            }
        }
    }
}
