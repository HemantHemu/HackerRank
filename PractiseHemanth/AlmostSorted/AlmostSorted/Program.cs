using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmostSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];
            string[] temp = Console.ReadLine().Split().ToArray();
            for(int i = 0;i<n;i++)
            {
                inputArray[i] = int.Parse(temp[i]);
            }
            int[] diffArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                diffArray[i] = 
            }
        }
    }
}
