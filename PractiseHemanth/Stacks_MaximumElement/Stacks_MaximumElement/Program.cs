using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = int.Parse(Console.ReadLine());
        int n1,max =0,n2;
        Stack<int> abc = new Stack<int> { };
        while (n > 0)
        {
            string[] inps = Console.ReadLine().Split();
            n1 = int.Parse(inps[0]);
            switch (n1)
            {
                case 1:
                    n2 = int.Parse(inps[1]);
                    abc.Push(n2);
                    max = (max > n2) ? max : n2;
                    break;
                case 2:
                    int temp = abc.Pop();
                    max = abc.Max();
                    break;
                case 3:
                    Console.WriteLine(max);
                    break;
            }

            n--;
        }
    }
}